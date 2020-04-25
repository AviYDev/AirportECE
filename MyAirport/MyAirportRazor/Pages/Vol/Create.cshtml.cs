using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using IA.MyAirport.EF;

namespace MyAirportRazor
{
    public class CreateModelVol : PageModel
    {
        private readonly IA.MyAirport.EF.MyAirportContext _context;

        public CreateModelVol(IA.MyAirport.EF.MyAirportContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Vol Vol { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Vols.Add(Vol);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
