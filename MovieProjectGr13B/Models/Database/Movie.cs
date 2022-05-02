using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieProjectGr13B.Models.Database
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Movie Title")]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Director")]
        public string Director { get; set; }

        [Required]
        [Range(1895,2050)]
        public int ReleaseYear { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(0,9999)]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        //[Required]
        [StringLength(255)]
        public string ImageLink { get; set; }

        virtual public ICollection<OrderRow> OrderRows { get; set; }
    }
}