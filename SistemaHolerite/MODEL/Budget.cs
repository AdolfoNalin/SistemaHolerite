using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.MODEL
{
    public class Budget
    {
        public int Cod { get; set; }
        public int CodClient{ get; set; }
        public int CodEmp { get; set; }
        public string Date{ get; set; }
        public string Payment { get; set; }
        public float Subtotal { get; set; }
        public float Total { get; set; }

        public Budget()
        {
            Date = DateTime.Now.ToShortDateString();
        }
    }
}
