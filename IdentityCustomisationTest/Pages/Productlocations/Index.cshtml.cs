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
    public class IndexModel : PageModel
    {
        private readonly IdentityCustomisationTest.Data.ApplicationDbContext _context;

        public IndexModel(IdentityCustomisationTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ProductLocation> ProductLocation { get;set; }

        public async Task OnGetAsync()
        {
            ProductLocation = await _context.ProductLocation
                .Include(p => p.Location)
                .Include(p => p.Product).ToListAsync();
        }
    }
}
