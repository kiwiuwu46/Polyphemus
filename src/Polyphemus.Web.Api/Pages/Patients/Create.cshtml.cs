using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Kiwi.Polyphemus.Persistence;
using Kiwi.Polyphemus.Persistence.Model;

namespace Kiwi.Polyphemus.Web.Api.Pages.Patients
{
    public class CreateModel : PageModel
    {
        private readonly Kiwi.Polyphemus.Persistence.PolyphemusDbContext _context;

        public CreateModel(Kiwi.Polyphemus.Persistence.PolyphemusDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Patient Patient { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Patients.Add(Patient);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
