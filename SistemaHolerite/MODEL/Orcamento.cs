using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.MODEL
{
    public class Orcamento
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdFun { get; set; }
        public float DP{ get; set; }
        public float Subtotal { get; set; }
        public float Total { get; set; }
    }
}
