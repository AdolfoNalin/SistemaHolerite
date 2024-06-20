using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.MODEL
{
    public class ItemPoint
    {
        public int Cod { get; set; }
        public int CodPoint { get; set; }
        public DateTime Date { get; set; }
        public Time EntryTime { get; set; }
        public Time LunchDeparture { get; set; }
        public Time LunchEntrance { get; set; }
        public Time ExitTime { get; set; }
        public Time ExtraEntry { get; set; }
        public Time ExtraOutput { get; set; }
    }
}
