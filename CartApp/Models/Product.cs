using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CartApp.Models
{
    public class Product
    {
        [Key]
        public Guid productId { get; set; }
        [Required]
        [Display(Name = "Price")]
        public double price { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }
        [Display(Name = "Category")]
        public string category { get; set; }
        [Display(Name = "Available Quantity")]

        public int availableQuantity { get; set; }
        public Guid cartId { get; set; }
    }
}
