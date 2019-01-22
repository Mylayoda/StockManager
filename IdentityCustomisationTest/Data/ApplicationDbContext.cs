using System;
using System.Collections.Generic;
using System.Text;
using IdentityCustomisationTest.Areas.Identity.Data;
using IdentityCustomisationTest.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityCustomisationTest.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Location> Location { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<ProductLocation> ProductLocation { get; set; }
    }
}
