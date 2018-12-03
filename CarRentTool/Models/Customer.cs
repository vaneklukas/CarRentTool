using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.Owin.Security.Provider;

namespace CarRentTool.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Jméno")]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Příjmení")]
        public string Surname { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Adresa bydliště")]
        public string Adress { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Město")]
        public string City { get; set; }

        [Required]
        [Display(Name = "PSČ")]
        public int PSC { get; set; }

        [Required]
        [Display(Name = "Telefoní číslo")]
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Řidičský průkaz číslo")]
        
        public int DrivingLicenceNo { get; set; }
        
        [Required]
        [Display(Name = "Občanský průkaz číslo")]
        public int PersonalCard { get; set; }
    }
}