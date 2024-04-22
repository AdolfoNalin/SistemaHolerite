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
    public class Funcionario : Cliente
    {
        public string Cargo { get; set; }
        public string Senha { get; set; }
    }
}
