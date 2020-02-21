using System;
using System.Collections.Generic;
using System.Text;

namespace IA.MyAirport.EF
{
    public class Bagage
    {
        public int id_bagage { get; set; }
        public int id_vol { get; set; }
        public String code_iata { get; set; }
        public DateTime date_creation { get; set; }
        public char classe { get; set; }
        public Byte prioritaire { get; set; }
        public char sta { get; set; }
        public string ssur { get; set; }
        public string destination { get; set; }
        public string escale { get; set; }


    }
}
