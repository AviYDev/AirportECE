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
    public class DeleteModelBagage : PageModel
    {
        private readonly IA.MyAirport.EF.MyAirportContext _context;

        public DeleteModelBagage(IA.MyAirport.EF.MyAirportContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Bagage Bagage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bagage = await _context.Bagages
                .Include(b => b.Vol).FirstOrDefaultAsync(m => m.BagageId == id);

            if (Bagage == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bagage = await _context.Bagages.FindAsync(id);

            if (Bagage != null)
            {
                _context.Bagages.Remove(Bagage);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
