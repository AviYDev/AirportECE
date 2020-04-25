using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IA.MyAirport.EF;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyAirportRazor.Pages.Bagage
{
    public class BagagesHelper
    {

        public static SelectList ListVolInfo(MyAirportContext context)
        {
            var vols = context.Vols.Select(v =>
            new { v.VolId, Description = $"{v.cie} {v.lig} : {v.dhc.ToShortDateString()}" }).ToList();

            return new SelectList(vols, "VolId", "Description");
        }
           
    }
}
