using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCustomisationTest.Models
{
   
        public class Location
        {
            public int LocationID { get; set; }
            //[Key]
            public int ShelfNo { get; set; }
            //[Required]
            public string Description { get; set; }

        }
    
}
