using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The code is required")]
        [StringLength(60, MinimumLength = 3)]
        public string Code { get; set; }
        [Required(ErrorMessage = "The title is required")]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
        [Range(0.1, 100000)]
        [Required(ErrorMessage = "The price is required")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
