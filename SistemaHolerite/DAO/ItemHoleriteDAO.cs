using MySql.Data.MySqlClient;
using SistemaHolerite.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.DAO
{
    public class ItemHoleriteDAO
    {
        private MySqlConnection _connection;
        public ItemHoleriteDAO()
        { 
            _connection = new ConnectionFactory().GetConnection();
        }


    }
}
