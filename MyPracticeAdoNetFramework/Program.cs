using AdoNetFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace MyPracticeAdoNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperation = 0;
            do
            {
                // list with variants what to do 
                WriteLine("1. Посчитать сумму заказов");
                WriteLine("2. Какое количество материалов заказали в конкретном месяце");
                WriteLine("3. Посчитать сумму заказов за определенный месяц");
                WriteLine("10. Выход");

                Console.WriteLine();

                Console.Write($"Выберете номер операции: ");
                numberOfOperation = Convert.ToInt32(Console.ReadLine());

                try
                {
                    var service = new ServiceConnection(); //через метод класса в проекте Ado.Net создаем перевенную
                    var connectionstring = service.CreateConnectionString(); // помещаем в эту переменную строку подключения к БД
                                                                             //делаем запрос на выгрузку информации о пользователях из БД
                    var serviceOrder = new ServiceOrder(connectionstring); // устанавливаем соединение с БД с конкретной таблицей

                    switch (numberOfOperation)
                    {

                        case 1:
                            var totalAmountOrders = serviceOrder.OrderTotalAmount();
                            foreach (var order in totalAmountOrders)
                            {
                                WriteLine($"Заказ номер {order.Number} составляет {order.TotalAmount} рублей");

                            }

                            break;

                        case 2:
                            var forMonthOrders = serviceOrder.OrderedForMonth();
                            foreach (var order in forMonthOrders)
                            {
                                WriteLine($"Количество заказов за {order.MonthName} составило {order.OrderCount}, в которых используется {order.MaterialCount} материалов.");
                            }
                            break;
                        case 3:
                            var priceMonthOrders = serviceOrder.OrderPriceForMonth();
                            foreach (var order in priceMonthOrders)
                            {
                                WriteLine($"Общая сумма заказов за {order.MonthName} месяц составляет {order.PriceCount} рублей.");
                            }
                            break;

                        case 10:
                            break;

                        default:
                            Write("Введите номер интересующей операции: ");
                            break;
                    }

                }
                catch (Exception exep)
                {
                    WriteLine($"Ошибка! {exep.Message}");
                }
                WriteLine("");
            } while (numberOfOperation > 0 & numberOfOperation < 10);

        }
    }
}
