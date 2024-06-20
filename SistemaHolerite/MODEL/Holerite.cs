using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.MODEL
{
    public class Holerite
    {
        public int Cod { get; set; }
        public int CodCompany { get; set; }
        public int CodEmployee{ get; set; }
        public float BasicSal { get; set; }
        public float SalContrINNS { get; set; }
        public float BasicCalcFGTS { get; set; }
        public float FGTSMonth{ get; set; }
        public float BasicCalcIRRF { get; set; }
        public int RangeIRRF { get; set; }
    }
}
