using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.MODEL
{
    public class ResumoGeral
    {
        public int CodPonto { get; set; }
        public float Horas { get; set; }
        public float Extra { get; set; }
        public float FaltaMes { get; set; }
        public float Subtotal { get; set; }
        public float INSS { get; set; }
        public float OutrosDes { get; set; }
        public float SalarioFam { get; set; }
        public float TLR { get; set; } // Total Liquido Recebido
        public float VistoFicalizacao { get; set; }
    }
}
