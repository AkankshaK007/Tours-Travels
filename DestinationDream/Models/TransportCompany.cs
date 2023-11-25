using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DestinationDream.Models
{
    public class TransportCompany
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public int CityId { get; set; }

        public string HQAddress { get; set; }

        public int CompanyTypeId { get; set; }

        public string Description { get; set; }

        public bool IsPartner { get; set; }

        public bool Active { get; set; }

    }
}