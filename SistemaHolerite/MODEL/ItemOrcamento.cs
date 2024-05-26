using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.MODEL
{
    public class ItemOrcamento
    {
        public int Id { get; set; }
        public int IdOrcamento { get; set; }
        public int IdProduto { get; set; }
        public int Qtd { get; set; }
        public float Price { get; set; }
    }
}
