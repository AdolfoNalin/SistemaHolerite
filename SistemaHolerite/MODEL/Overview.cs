using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.MODEL 
{
    public class Overview
    {
        public int Cod { get; set; }
        public int CodPonto { get; set; }
        public DateTime Time { get; set; }
        public DateTime ExtraTime { get; set; }
        public float MissingMoth { get; set; }
        public float Subtotal { get; set; }
        public float INSS { get; set; }
        public float OthersDes { get; set; }
        public float WageFam { get; set; }
        public float TLR { get; set; } // Total Liquido Recebido
        public float VisaInspection { get; set; }
    }
}
