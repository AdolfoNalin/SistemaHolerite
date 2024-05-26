using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.MODEL
{
    public class Servico
    {

        public int Id { get; set; }
        public string DR { get; set; }
        public string DC { get; set; }
        public int IdRes { get; set; }
        public float PV { get; set; }
        public float PP { get; set; }
        public string Obs { get; set; }
    }
}
