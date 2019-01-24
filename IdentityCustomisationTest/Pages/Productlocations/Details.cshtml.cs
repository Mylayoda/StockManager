using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IdentityCustomisationTest.Data;
using IdentityCustomisationTest.Models;

namespace IdentityCustomisationTest.Pages.Productlocations
{
    public class DetailsModel : PageModel
    {
        private readonly IdentityCustomisationTest.Data.ApplicationDbContext _context;

        public DetailsModel(IdentityCustomisationTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public ProductLocation ProductLocation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductLocation = await _context.ProductLocation
                .Include(p => p.Location)
                .Include(p => p.Product).FirstOrDefaultAsync(m => m.ProductLocationId == id);

            if (ProductLocation == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
