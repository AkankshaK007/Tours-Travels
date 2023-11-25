using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DestinationDream.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal MobileNo { get; set; }
        public string Email { get; set; }
        public string Details { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}