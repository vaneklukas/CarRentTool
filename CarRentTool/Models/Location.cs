using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRentTool.Models
{
    public class Location
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Město")]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Adresa")]
        public string Adress { get; set; }

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefon")]
        public string Phone { get; set; }
    }
}