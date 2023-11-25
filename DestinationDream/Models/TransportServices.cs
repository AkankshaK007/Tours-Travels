using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DestinationDream.Models
{
    public class TransportServices
    {
        public int Id { get; set; }
        public int TransportCompanyTypeId { get; set; }
        public int TicketTypeId { get; set; }
        public int FromCityId { get; set; }
        public int ToCityId { get; set; }
        public decimal ServicePrice { get; set; }
        public bool Active { get; set; }

    }
}