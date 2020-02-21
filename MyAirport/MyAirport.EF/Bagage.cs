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
        public String date_creation { get; set; }
    }
}
