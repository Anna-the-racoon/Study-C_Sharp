using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdoNetFramework
{
    public class ServiceOrder
    {
        private readonly string connectionstring;

        public ServiceOrder() { }

        public ServiceOrder(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }

        public List<OrderTotalAmount> OrderTotalAmount()
        {
            var orders = new List<OrderTotalAmount>();

            using (var connection = new SqlConnection(connectionstring))
            {
                    connection.Open();

                    var command = new SqlCommand($"SELECT Orders.Id, Orders.Number,Orders.Date, " +
                        $"SUM(Materials.Price*Materials.Quantity) AS TotalAmount " +
                        $"FROM[usersdb].[dbo].[Orders] " +
                        $"LEFT OUTER JOIN[usersdb].[dbo].[Materials] " +
                        $"ON Orders.Id = Materials.OrderId " +
                        $"GROUP BY Orders.Id, Number, [Date]", connection);

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var order = new OrderTotalAmount()
                    {
                        Id = reader.GetInt32(0),
                        Number = reader.GetInt32(1),
                        Date = reader.GetDateTime(2),
                        TotalAmount = reader.IsDBNull(3)  ? 0 : reader.GetDecimal(3)
                    };
                    orders.Add(order);
                }
                connection.Close();
            }
            return orders;
        }

        public List<OrderedForMonth> OrderedForMonth ()
        {
            var monthOrders = new List<OrderedForMonth>();
            using(var connection = new SqlConnection(connectionstring))
            {
                connection.Open();

                var command = new SqlCommand($"SELECT DATENAME(month, [Date]) AS MonthName2, COUNT(Number) AS OrderCount, COUNT(Materials.Materials) AS MaterialCount " +
                    $"FROM[usersdb].[dbo].[Orders] " +
                    $"LEFT OUTER JOIN[usersdb].[dbo].[Materials] " +
                    $"ON Orders.Id = Materials.OrderId " +
                    $"GROUP BY DATENAME(month, [Date])" +
                    $"ORDER BY DATENAME(month, [Date]) ", connection);

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var monthOrder = new OrderedForMonth()
                    {
                        MonthName = reader.GetString(0),
                        OrderCount = reader.GetInt32(1),
                        MaterialCount = reader.GetInt32(2)
                    };
                    monthOrders.Add(monthOrder);
                }
                connection.Close();
            }
            return monthOrders;
        }

        public List<OrderPriceForMonth> OrderPriceForMonth() 
        {
                var orders = new List<OrderPriceForMonth>();
                using (var connection = new SqlConnection(connectionstring))
                {
                    connection.Open();

                    var command = new SqlCommand($"SELECT DATENAME(month, [Date]) AS MonthName, SUM(Price*Quantity) AS PriceCount " +
                        $"FROM[usersdb].[dbo].[Orders] " +
                        $"LEFT OUTER JOIN[usersdb].[dbo].[Materials] " +
                        $"ON Orders.Id = Materials.OrderId " +
                        $"GROUP BY DATENAME(month, [Date]) " +
                        $"ORDER BY DATENAME(month, [Date])", connection);

                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var order = new OrderPriceForMonth()
                        {
                            MonthName = reader.GetString(0),
                            PriceCount = reader.GetDecimal(1)
                        };
                        orders.Add(order);
                    }
                    connection.Close();
                }
                return orders;
        }

        public DataTable GetOrdersNumbers()
        {
            var service = new ServiceConnection();
            string connectionString = service.CreateConnectionString();
            var datatable = new DataTable();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var adapter = new SqlDataAdapter($"SELECT Id, Number FROM Orders", connection);
                adapter.Fill(datatable);
                connection.Close();
            }
            return datatable;
        }

    }
}
