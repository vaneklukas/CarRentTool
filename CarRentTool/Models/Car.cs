using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRentTool.Models
{
    public class Car
    {
        public int ID { get; set; }
        public int Availible { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Výrobce")]
        public string Manufacturer { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Model")]
        public string Model { get; set; }

        [Required]
        [Display(Name = "Rok výroby")]
        public int Year { get; set; }

        [Required]
        [Display(Name = "Počet Km")]
        public int Km { get; set; }

        [Required]
        [Display(Name = "Počet sedadel")]
        public int NoSeats { get; set; }

        [Required]
        [Display(Name = "Cena za den")]
        public decimal priceDay { get; set; }

        [Required]
        [Display(Name = "Cena za Km")]
        public decimal priceKm { get; set; }


        
        public Location Location { get; set; }
        public int LocationId { get; set; }
    }
}