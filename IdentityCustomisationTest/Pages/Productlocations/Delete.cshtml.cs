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
    public class DeleteModel : PageModel
    {
        private readonly IdentityCustomisationTest.Data.ApplicationDbContext _context;

        public DeleteModel(IdentityCustomisationTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductLocation = await _context.ProductLocation.FindAsync(id);

            if (ProductLocation != null)
            {
                _context.ProductLocation.Remove(ProductLocation);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
