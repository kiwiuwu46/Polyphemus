using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Kiwi.Polyphemus.Persistence;
using Kiwi.Polyphemus.Persistence.Model;

namespace Kiwi.Polyphemus.Web.Api.Pages.Patients
{
    public class DetailsModel : PageModel
    {
        private readonly Kiwi.Polyphemus.Persistence.PolyphemusDbContext _context;

        public DetailsModel(Kiwi.Polyphemus.Persistence.PolyphemusDbContext context)
        {
            _context = context;
        }

        public Patient Patient { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _context.Patients.FirstOrDefaultAsync(m => m.Id == id);
            if (patient == null)
            {
                return NotFound();
            }
            else
            {
                Patient = patient;
            }
            return Page();
        }
    }
}
