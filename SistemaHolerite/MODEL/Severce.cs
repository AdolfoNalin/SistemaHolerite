using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.MODEL
{
    public class Severce
    {
        public int Cod { get; set; }
        public string BriefDescription { get; set; }
        public string FullDescription { get; set; }
        public int CodEmp { get; set; }
        public float CashPrice { get; set; }
        public float TermPrice { get; set; }
        public string Observation { get; set; }
    }
}
