using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CartApp.Models
{
    public class Cart
    {
        [Key]
        public Guid cartId { get; set; }
        [Display(Name = "Products")]
        public List<Product> products { get; set; }
        [Display(Name = "Total price")]

        public double totalPrice { get; set; } = 0.0;
    }
}
