using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCustomisationTest.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public float price { get; set; }
        public int Quantity { get; set; }

    }
}
