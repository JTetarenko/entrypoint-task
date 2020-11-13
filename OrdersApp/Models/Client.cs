using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;

namespace OrdersApp.Models
{
    public enum GenderType
    {
        Male, Female
    }
    public class Client
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The name is required")]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }
        [Required(ErrorMessage = "The email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "The birth date is required")]
        [Display(Name = "Birth date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = false)]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "The gender is required")]
        public GenderType Gender { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
    public class ClientViewModel
    {
        public int Id { get; set; }
        public GenderType Gender { get; set; }
        [Display(Name = "Gender name")]
        public string GenderName
        {
            get
            {
                GenderType _gender = (GenderType)Gender;
                return _gender.ToString();
            }
        }
        public string Name { get; set; }
        public string Email { get; set; }
        [Display(Name = "Birth date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = false)]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Orders quantity")]
        public virtual int OrdersQty { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name = "Average orders price")]
        public virtual decimal AvgOrdersPrice { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
