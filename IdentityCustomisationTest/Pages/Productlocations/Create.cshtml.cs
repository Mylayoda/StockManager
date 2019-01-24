using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using IdentityCustomisationTest.Data;
using IdentityCustomisationTest.Models;

namespace IdentityCustomisationTest.Pages.Productlocations
{
    public class CreateModel : PageModel
    {
        private readonly IdentityCustomisationTest.Data.ApplicationDbContext _context;

        public CreateModel(IdentityCustomisationTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["LocationID"] = new SelectList(_context.Location, "LocationID", "LocationID");
        ViewData["ProductID"] = new SelectList(_context.Product, "ProductID", "ProductID");
            return Page();
        }

        [BindProperty]
        public ProductLocation ProductLocation { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ProductLocation.Add(ProductLocation);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}