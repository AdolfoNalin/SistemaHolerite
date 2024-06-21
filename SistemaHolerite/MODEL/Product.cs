using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.MODEL
{
    public class Product : Severce, IEPIs
    {
        public int Amount { get; set; }
        public int CodSupplier { get; set; }
        public string CA { get; set; }
    }
}
