using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.MODEL
{
    public class ItemBudget
    {
        public int Cod { get; set; }
        public int CodBudget{ get; set; }
        public int CodProduct{ get; set; }
        public float Price { get; set; }
        public int Amount{ get; set; }
        public float Subtotal { get; set; }
    }
}
