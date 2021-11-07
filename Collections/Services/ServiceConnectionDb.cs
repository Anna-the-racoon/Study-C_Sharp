using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Services
{
    internal class ServiceConnectionDb
    {
        public string CreateConnectionString()
        {
            var builder = new SqlConnectionStringBuilder(); 
            builder.DataSource = "RUTL-R90QFPYV";
            builder.InitialCatalog = "usersdb";
            builder.IntegratedSecurity = true;
            return builder.ConnectionString;
        }
    }
}
