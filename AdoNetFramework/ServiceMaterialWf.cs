using System;
using System.Data;
using System.Data.SqlClient;

namespace AdoNetFramework
{
    public class ServiceMaterialWf
    {
        public DataTable GetMaterials()
        {
            var service = new ServiceConnection();
            var connectionString = service.CreateConnectionString();
            var datatable = new DataTable();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var adapter = new SqlDataAdapter($"SELECT * FROM Materials", connection);
                adapter.Fill(datatable);
                connection.Close();
            }
            return datatable;
        }

        public void CreateMaterial(string name, int quantity, decimal price, int orderId)
        {
            var service = new ServiceConnection();
            var connectionString = service.CreateConnectionString();

            using (var connectionForCreate = new SqlConnection(connectionString))
            {
                var command = new SqlCommand($"INSERT INTO Materials (Materials, Quantity, Price, OrderId) VALUES (@name, @quantity, @price, @orderId); SET @id = SCOPE_IDENTITY()", connectionForCreate);

                var idParameter = new SqlParameter
                {
                    ParameterName = "@id",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(idParameter);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@orderId", orderId);

                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.InsertCommand = command;

                connectionForCreate.Open();

                var transaction = connectionForCreate.BeginTransaction();

                try
                {
                    command.Transaction = transaction;

                    var reader = command.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
                finally
                {
                    connectionForCreate.Close();
                }
            }
        }

        public void UpdateMaterials (int id, string name, int quantity, decimal price, int orderId)
        {
            var service = new ServiceConnection();
            var connectionString = service.CreateConnectionString();

            using (var connectionForUpdate = new SqlConnection(connectionString))
            {
                var command = new SqlCommand($"UPDATE Materials SET Materials=@name, Quantity=@quantity, Price=@price, OrderId=@orderId WHERE Id=@id", connectionForUpdate);

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@orderId", orderId);

                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.InsertCommand = command;

                connectionForUpdate.Open();
                var transaction = connectionForUpdate.BeginTransaction();
                try
                {
                    command.Transaction = transaction;

                    var reader = command.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
                finally 
                {
                    connectionForUpdate.Close();
                }
            }
        }

        public void DeleteMaterials(int id) 
        {
            var service = new ServiceConnection();
            var connectionString = service.CreateConnectionString();

            using (var connectionStringForDelete = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("DELETE FROM Materials WHERE Id=@id ", connectionStringForDelete);

                command.Parameters.AddWithValue("@id", id);

                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.InsertCommand = command;

                connectionStringForDelete.Open();
                var transaction = connectionStringForDelete.BeginTransaction();
                // в конструкции должны быть указаны только те операции которые касаются выполнения самой транзакции,
                //т. е. только те операции которые напрямую ведут работу с нашей БД и 
                //только те, чья совокупность должна оказаться в бд
                try
                {
                    command.Transaction = transaction;

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
                    connectionStringForDelete.Close();
                }
            }

        }
    }
}

