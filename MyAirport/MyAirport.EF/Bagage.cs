using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IA.MyAirport.EF
{
    public class Bagage
    {
    
        public int BagageId { get; set; }
        public String code_iata { get; set; }
        public DateTime date_creation { get; set; }
        public int? VolId { get; set; }
        public Vol? Vol { get; set; }
        public string? classe { get; set; }
        public bool? prioritaire { get; set; }
        public char? sta { get; set; }
        public string? ssur { get; set; }
        public string? destination { get; set; }
        public string? escale { get; set; }

    }
}
