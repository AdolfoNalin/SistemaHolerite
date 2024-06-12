using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.MODEL
{
    public class Ponto
    {
        public int Cod { get; set; }
        public Empregado Empregado { get; set; }
        public Empresa Empresa { get; set; }
    }
}
