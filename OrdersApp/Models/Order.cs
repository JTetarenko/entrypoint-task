using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Display(Name = "Client name")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        [Display(Name = "Product code")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public enum StatusTypes
        {
            Created,
            Paid,
            Delivered
        }
        public byte Status { get; set; }
        [Display(Name = "Status")]
        public string StatusName
        {
            get
            {
                StatusTypes _status = (StatusTypes)Status;
                return _status.ToString();
            }
        }
        [NotMapped]
        [DataType(DataType.Currency)]
        [Display(Name = "Order price")]
        public virtual decimal OrderPrice { get; set; }
    }
}
