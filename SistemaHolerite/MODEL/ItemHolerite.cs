using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.MODEL
{
    public class ItemHolerite
    {
        public int Cod { get; set; }
        public int CodHolerite { get; set; }
        public int CodAttributes { get; set; }
        public string Description{ get; set; }
        public decimal Reference { get; set; }
        public float Earnings { get; set; }
        public float Discount { get; set; }
        public float TotalEarnings { get; set; }
        public float TotalDiscount { get; set; }
    }
}
