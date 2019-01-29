using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCustomisationTest.Models
{
    public class Customer
    {
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
    }
}
