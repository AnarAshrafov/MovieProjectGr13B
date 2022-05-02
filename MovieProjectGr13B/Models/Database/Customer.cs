using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieProjectGr13B.Models.Database
{
    public class Customer
    {
        public int Id { get; set; }

        
        [Required]
        [StringLength(50)]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(150)]
        [Display(Name = "Billing Address")]
        public string BillingAddress { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Billing Zip")]
        public string BillingZip { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Billing City")]
        public string BillingCity { get; set; }

        [Required]
        [StringLength(150)]
        [Display(Name = "Delivery Address")]
        public string DeliveryAddress { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Delivery Zip")]
        public string DeliveryZip { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Delivery City")]
        public string DeliveryCity { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        [StringLength(255)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [StringLength(25)]
        [Display(Name ="Phone Number")]
        public string PhoneNumber { get; set; }

        virtual public ICollection<Order> Orders { get; set; }

    }
}