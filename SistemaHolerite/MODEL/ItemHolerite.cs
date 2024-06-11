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
        public int Codigo { get; set; }
        public string Descricao{ get; set; }
        public decimal Referencia { get; set; }
        public float Proventos { get; set; }
        public float Descontos { get; set; }
        public float TotalProventos { get; set; }
        public float TotalDesconto { get; set; }
    }
}
