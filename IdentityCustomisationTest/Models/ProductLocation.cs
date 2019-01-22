using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCustomisationTest.Models
{
    public class ProductLocation
    {
        public int ProductLocationId { get; set; }
        public int LocationID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }

        public Product Product { get; set; }
        public Location Location { get; set; }


    }
}
