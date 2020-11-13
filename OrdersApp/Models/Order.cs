using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApp.Models
{
    public enum StatusType
    {
        Created,
        Paid,
        Delivered
    }
    public class Order
    {
        public int Id { get; set; }
        [Display(Name = "Client name")]
        [Required(ErrorMessage = "The client name is required")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        [Display(Name = "Product code")]
        [Required(ErrorMessage = "The product code is required")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        [Required(ErrorMessage = "The quantity is required")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "The status is required")]
        public StatusType Status { get; set; }
    }
    
    public class OrderViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Client name")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        [Display(Name = "Product code")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public StatusType Status { get; set; }
        [Display(Name = "Status")]
        public string StatusName
        {
            get
            {
                StatusType _status = (StatusType)Status;
                return _status.ToString();
            }
        }
        [NotMapped]
        [DataType(DataType.Currency)]
        [Display(Name = "Order price")]
        public virtual decimal OrderPrice { get; set; }
    }
}
