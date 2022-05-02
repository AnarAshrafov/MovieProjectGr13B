using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieProjectGr13B.Models.Database
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Order Sum")]
        public decimal OrderSum { get; set; }

        virtual public Customer Customer { get; set; }

        virtual public ICollection<OrderRow> OrderRows { get; set; }
    }
}