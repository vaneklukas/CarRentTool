using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentTool.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }
    }
}