using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCustomisationTest.Models
{
    public class Employee
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
    }
}
