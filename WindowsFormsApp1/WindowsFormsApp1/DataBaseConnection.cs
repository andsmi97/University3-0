using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    class DataBaseConnection
    {
        public DbConnection GetDatabeseConnection(string name)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            DbProviderFactory factory = DbProviderFactories.GetFactory(settings.ProviderName);
            DbConnection conn = factory.CreateConnection();
            conn.ConnectionString = settings.ConnectionString;

            return conn;
        }
    }
}
