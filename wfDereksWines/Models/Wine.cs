using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace wfDereksWines.Models
{
    public class Wine
    {
        public int WineID { get; set; }

        [Required, StringLength(30), Display(Name = "Wine Name")]
        public string Name { get; set; }

        [StringLength(512)]
        public string Description { get; set; }

        [StringLength(120), Display(Name ="Image Path")]
        public string ImagePath { get; set; }

        [StringLength(30)]
        public string Producer { get; set; }

        [StringLength(20)]
        public string Country { get; set; }

        public WineColours Colour { get; set; }

        [Range(1990,2018), Required]
        public int Vintage { get; set; }

        [Range(4.5, 18.0), Required]
        public double Alcohol { get; set; }

        [Range(1,5)]
        public double Rating { get; set; }


        public decimal Price { get; set; }

        [Range(0,100)]
        public double CaseDiscount { get; set; }
    }

    public enum WineColours
    {
        White,
        Rose,
        Red
    }
}