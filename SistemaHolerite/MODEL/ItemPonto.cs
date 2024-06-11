using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.MODEL
{
    public class ItemPonto
    {
        public int CodPonto { get; set; }
        public DateTime Data { get; set; }
        public Time HoraEntrada { get; set; }
        public Time SaidaAlmoco { get; set; }
        public Time EntradaAlmoco { get; set; }
        public Time Saida { get; set; }
        public Time EntradaExtra { get; set; }
        public Time SaidaExtra { get; set; }
    }
}
