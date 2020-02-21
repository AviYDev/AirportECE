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
<<<<<<< HEAD
        public char sta { get; set; }
=======

        public char sta { get; set; }

>>>>>>> fd73d9898804f80b74c3edc08166b09aa0eff264
        public string ssur { get; set; }
        public string destination { get; set; }
        public string escale { get; set; }


    }
}
