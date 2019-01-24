using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IdentityCustomisationTest.Data;
using IdentityCustomisationTest.Models;

namespace IdentityCustomisationTest.Pages.Productlocations
{
    public class EditModel : PageModel
    {
        private readonly IdentityCustomisationTest.Data.ApplicationDbContext _context;

        public EditModel(IdentityCustomisationTest.Data.ApplicationDbContext context)
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
           ViewData["LocationID"] = new SelectList(_context.Location, "LocationID", "LocationID");
           ViewData["ProductID"] = new SelectList(_context.Product, "ProductID", "ProductID");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ProductLocation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductLocationExists(ProductLocation.ProductLocationId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProductLocationExists(int id)
        {
            return _context.ProductLocation.Any(e => e.ProductLocationId == id);
        }
    }
}
