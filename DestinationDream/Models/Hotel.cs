using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DestinationDream.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; }
        public string Details { get; set; }
        public bool IsPartner { get; set; }
        public bool Active { get; set; }
    }
}