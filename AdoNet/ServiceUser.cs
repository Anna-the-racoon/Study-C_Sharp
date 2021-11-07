using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace AdoNet
{
    /// <summary>
    /// Здесь перечисляется весь функционал, который можно делать с базой данных
    /// </summary>
    public class ServiceUser
    {
        private readonly string connectionstring; // вызываем сюда строку подключения к БД

        public ServiceUser(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }


        public List<User> GetUsers()
        {               
            var users = new List<User>(); //инициализируем класс список, благодаря которому будем выгружать данные

            using (var connection = new SqlConnection(connectionstring)) //устанавливаем соединение с БД
            {
                connection.Open();
                var command = new SqlCommand("SELECT*FROM Users",connection); // у данного конструктора есть 4 варианта. выбирать по ситуации
                // запись означает, что объект command инициализирется через SqlCommand класс
                //вызывается конкретная команда для работы и уточняется с какой из таблиц нужно будет работать
                //устанавливается соединение

                var reader = command.ExecuteReader();  //вызываем метод для работы с командой и инициализируем это как значение переменной, которую в дальнейшем можно будет использовать
                
                if(reader.HasRows) //проверяем таблицу на наличие строк в ней
                    //вызывается одна из функций для работы с методой данной команды
                {
                    while (reader.Read()) //заставляем прочитать каждую строку
                    {
                        var user = new User() 
                        { 
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Age = reader.GetInt32(2)
                        };

                        users.Add(user);
                    }
                }
                connection.Close(); // отключаем подключение от бд
            }

            return users; // на эеране выдается информация из БД
        }

        public int GetScalarMinAge()
        {
            var minAge = 0;
            using(var connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                var command = new SqlCommand("SELECT MIN(Age) FROM Users", connection);
                minAge = (int) command.ExecuteScalar();
                connection.Close();
            }
            return minAge;
        }

        public void CreateUser(string name, int age)
        {
            if (name == null) 
            {
                throw new Exception("Вы не ввели имя пользователя");
            }
            else if (name.Length > 50)
                {
                    throw new Exception("Имя не может быть больше 50 символов");
                }

            if (age < 0 & age > 150)
            {
                throw new Exception("Введен не верный возраст");
            }
         

            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                var command = new SqlCommand($"INSERT INTO Users (Name, Age) VALUES (@name, @age); SET @id = SCOPE_IDENTITY()", connection);

                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@age", age);

                //покажет номер id для только что созданного объекта
                var idParameter = new SqlParameter
                {
                    ParameterName = "@id",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(idParameter);
                //нчало транзакции

                var transaction = connection.BeginTransaction();
                
                command.Transaction = transaction;

                try
                {
                    // search command for work
                    var reader = command.ExecuteNonQuery();
                    transaction.Commit(); // завершение транзакции
                }
                catch 
                {
                    transaction.Rollback(); // откат на случай ошибки 
                }
                finally
                {
                    //завершаем выполнение работы 
                    connection.Close();
                }
            }
        }

        public void UpdateUser(int id, string name, int age)
        {
            if (id == 0)
                throw new Exception("Id не может быть равен 0");

            if (name.Length > 50)
                throw new Exception("Имя не может быть бльше 50 символов");

            if (age < 0 & age > 150)
            {
                throw new Exception("Некорректно введен возраст");
            }

            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Open();            

                var command = new SqlCommand($"UPDATE Users SET Name=@name, Age=@age WHERE Id=@id", connection);
                
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@age", age);

                var transaction = connection.BeginTransaction();
                command.Transaction = transaction;

                try
                {
                    var reader = command.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        public void DeleteUser (int id)
        { 
            using(var connection = new SqlConnection(connectionstring))
            {
                connection.Open();


                var command = new SqlCommand($"DELETE FROM Users WHERE Id={id}", connection);
                var transaction = connection.BeginTransaction();
                command.Transaction = transaction;

                try
                {
                    var reader = command.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
                finally 
                {
                    connection.Close();

                }
            }
        }

        public void GetException()
        {
            throw new Exception("Здесь возникает Exception");
        }


        // запрос выполняется после чего происходит закрытие коннекшена
    }
}
