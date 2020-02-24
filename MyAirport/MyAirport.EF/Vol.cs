using System;
using System.Collections.Generic;
using System.Text;

namespace IA.MyAirport.EF
{
    public class Vol
    {
        public int VolId { get; set; }
        public String cie { get; set; }
        public String lig { get; set; }
        public DateTime dhc { get; set; }
        public String pkg { get; set; }
        public String imm { get; set; }
        public short pax { get; set; }
        public string des { get; set; }

    }
}
