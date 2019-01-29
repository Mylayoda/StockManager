using IdentityCustomisationTest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCustomisationTest.Data
{
    public class DbInitializer
    {
            public static void Initialize(ApplicationDbContext context)
            {
                // context.Database.EnsureCreated();

                // Look for any students.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                var myProduct = new Models.Product[]

                {
            new Models.Product{Name="Alexander",Description="computer",price=200,Quantity=8},
            new Models.Product{Name="Alexande",Description="computer",price=400,Quantity=4},
            new Models.Product{Name="Alexaner",Description="computer",price=600,Quantity=89},
            new Models.Product{Name="Alexader",Description="computer",price=200, Quantity=10},


                };
                foreach (Models.Product s in myProduct)
                {
                    context.Product.Add(s);
                }
                context.SaveChanges();

            }
       
    }
}
