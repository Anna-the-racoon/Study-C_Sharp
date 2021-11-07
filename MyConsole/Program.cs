using AdoNet;
using System;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {


           var result = 0;

            do
            {
                Console.WriteLine("1. Показывает список пользователей");
                Console.WriteLine("2. Создает нового пользователя");
                Console.WriteLine("3. Изменение текущего пользователя");
                Console.WriteLine("4. Удаление действующего пользователя");
                Console.WriteLine("5. Выведение минимального возраста у пользователя");
                Console.WriteLine("6. Выход");
                Console.WriteLine();

                Console.Write($"Выберете номер операции: ");
                result = Convert.ToInt32(Console.ReadLine());

                //step 0 connection
                //сдесь выполняет роль обработки исключений в рамках выполнения программы
                try
                {
                    var service = new ServiceConnection(); //через метод класса в проекте Ado.Net создаем перевенную
                    var connectionstring = service.CreateConnectionString(); // помещаем в эту переменную строку подключения к БД
                                                                             //делаем запрос на выгрузку информации о пользователях из БД
                    var serviceUser = new ServiceUser(connectionstring); // устанавливаем соединение с БД с конкретной таблицей


                    switch (result)
                    {
                        case 1:
                            // step 1 read
                            var User = serviceUser.GetUsers(); // передаем запрос 
                            foreach (var user in User) // запускаем цикл обхода нашего столбца в конкретной таблице 
                            {
                                Console.WriteLine($"{user.Id}, {user.Name}, {user.Age}"); // выводим на экран строки из таблицы 
                            }
                            break;

                        // step 2 insert

                        case 2:
                            // step 2.1 create
                            Console.WriteLine("Введите имя:");
                            string nameInsert = Console.ReadLine();
                            Console.WriteLine("Введите возраст:");
                            string ageStringInsert = Console.ReadLine();
                            int ageInsert = int.Parse(ageStringInsert); // проводим перобразование типа из string в int
                            serviceUser.CreateUser(nameInsert, ageInsert);
                            break;

                        case 3:
                            //step 2.2 update
                            Console.WriteLine("Введите имя пользователя, которое необходимо заменить:");
                            string nameUpdate = Console.ReadLine();
                            Console.WriteLine("Введите возраст:");
                            string ageStringUpdate = Console.ReadLine();
                            int ageUpdate = int.Parse(ageStringUpdate); // проводим перобразование типа из string в int
                            Console.WriteLine("Введите номер пользлвателя:");
                            int id = int.Parse(Console.ReadLine());
                            serviceUser.UpdateUser(id, nameUpdate, ageUpdate);
                            break;

                        case 4:
                            //step 2.3 delete
                            Console.WriteLine("Введите номер пользователя, чьи данные необходимо удалить:");
                            int idDelete = int.Parse(Console.ReadLine());
                            serviceUser.DeleteUser(idDelete);

                            break;

                        case 5:
                            // step 2.4 scalar
                            Console.Write($"Минимальный возраст пользователя составляет {serviceUser.GetScalarMinAge()}");
                            break;

                        case 6:
                            break;


                        default:
                            Console.WriteLine("Введено не верное значение.");
                            break;
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"Exception: {exception.Message}");
                }
                Console.WriteLine();
            } while (result > 0 & result < 6);
        }
    }
}
