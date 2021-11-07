using System.Data.SqlClient;

namespace AdoNet
{
    /// <summary>
    /// сервис который обрабатывает коннекшен
    /// </summary>
    public class ServiceConnection
    {
        //функция создает стороку подключения
        public string CreateConnectionString()
        {
            var builder = new SqlConnectionStringBuilder(); // инициализируем переменную класса SqlConnectionStringBuilder
            //создаем строку подключения
            builder.DataSource = "RUTL-R90QFPYV";
            builder.InitialCatalog = "usersdb";
            builder.IntegratedSecurity = true;
            //возвращаем готовую строку поключения
            return builder.ConnectionString;
        }
    }
}