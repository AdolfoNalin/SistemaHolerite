using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SistemaHolerite.Connection
{
    public class ConnectionFactory
    {
        public MySqlConnection GetConnection()
        {
            string connection = ConfigurationManager.ConnectionStrings["bdholerite"].ConnectionString;
            return new MySqlConnection(connection);
        }
    }
}
