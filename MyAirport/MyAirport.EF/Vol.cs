using System;
using System.Collections.Generic;
using System.Text;

namespace IA.MyAirport.EF
{
    public class Vol
    {
        /// <summary>
        /// Class Vol, instance de vol
        /// </summary>

        public Vol()
        {
            this.bagages = new HashSet<Bagage>();
        }
        /// <summary>
        /// Clef primaire d'un vol
        /// </summary>
        public int VolId { get; set; }

        /// <summary>
        /// Compagnie du vol
        /// </summary>
        public String cie { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public String lig { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        public DateTime dhc { get; set; }
        /// <summary>
        /// Parking du vol
        /// </summary>
        public String? pkg { get; set; }

        /// <summary>
        /// Immatriculation du vol
        /// </summary>
        public String? imm { get; set; }
        public short? pax { get; set; }
        public string? des { get; set; }
        public virtual ICollection<Bagage>? bagages { get; set; }


    }
}
