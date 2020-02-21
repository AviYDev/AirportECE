using System;
using System.Collections.Generic;
using System.Text;

namespace IA.MyAirport.EF
{
    public class Bagage
    {
        public int BagageId { get; set; }
        public int VolId { get; set; }
        public Vol Vol { get; set; }
        public String code_iata { get; set; }
        public DateTime date_creation { get; set; }
        public char classe { get; set; }
<<<<<<< HEAD
        public bool prioritaire { get; set; }
=======
        public Byte prioritaire { get; set; }

>>>>>>> d643f7956648b8d102ff7525b688cd9021491270
        public char sta { get; set; }


        public string ssur { get; set; }
        public string destination { get; set; }
        public string escale { get; set; }

    }
}
