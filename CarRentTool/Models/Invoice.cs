using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentTool.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime DateOfInvoice { get; set; }
        public int InvoiceNumber { get; set; }
        public decimal Price { get; set; }
    }
}