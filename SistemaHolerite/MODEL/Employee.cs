using MySql.Data.MySqlClient;
using SistemaHolerite.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.MODEL
{
    public class Employee : Client,IUsuario
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<String> Permissions { get; set; }
        public float Wage { get; set; }
        public string Function { get; set; }
    }
}
