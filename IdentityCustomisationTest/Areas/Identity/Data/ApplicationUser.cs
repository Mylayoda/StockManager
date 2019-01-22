using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCustomisationTest.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string Address { get; set; }
        public string Name { get; set; }

        // link user to collections here if needed



    }
    //public class Administrator
    //{

    //    public int ID { get; set;}
    //    public string Name { get; set; }
    //    public string Password { get; set; } 
    //    public string Email { get; set; }
    //}
    //public class Employee
    //{
    //    public int ID { get; set;}
    //    public string Name { get; set; }
    //    public string Password { get; set; }
    //    public string Email { get; set; }
    //}

    


}
