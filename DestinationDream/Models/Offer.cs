using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DestinationDream.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ActiveFrom { get; set; }
        public DateTime ActiveTo { get; set; }
        public DateTime TimeAccepted { get; set; }
        public bool Accepted { get; set; }
        public int PromoOfferId { get; set; }
        public int AgentId { get; set; }
        public int CustomerId { get; set; }

    }
}