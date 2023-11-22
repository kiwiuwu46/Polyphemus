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
    public class IndexModel : PageModel
    {
        private readonly Kiwi.Polyphemus.Persistence.PolyphemusDbContext _context;

        public IndexModel(Kiwi.Polyphemus.Persistence.PolyphemusDbContext context)
        {
            _context = context;
        }

        public IList<Patient> Patient { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Patient = await _context.Patients.ToListAsync();
        }
    }
}
