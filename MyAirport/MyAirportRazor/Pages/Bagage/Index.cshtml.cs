using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IA.MyAirport.EF;

namespace MyAirportRazor
{
    public class IndexModelBagage : PageModel
    {
        private readonly IA.MyAirport.EF.MyAirportContext _context;

        public IndexModelBagage(IA.MyAirport.EF.MyAirportContext context)
        {
            _context = context;
        }

        public IList<Bagage> Bagage { get;set; }

        public async Task OnGetAsync()
        {
            Bagage = await _context.Bagages
                .Include(b => b.Vol).ToListAsync();
        }
    }
}
