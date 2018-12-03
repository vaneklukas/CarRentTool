using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentTool.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Km { get; set; }
        public int NoSeats { get; set; }

    }
}