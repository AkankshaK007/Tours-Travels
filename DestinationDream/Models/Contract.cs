using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DestinationDream.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public string Code { get; set; }

        public int CustomerId { get; set; }
        public int AgentId { get; set; }
        public int OfferId { get; set; }
        public DateTime TimeSigned { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime PaymentDate { get; set; }
        public bool Paid { get; set; }
        public DateTime PaymentTime { get; set; }
        public decimal PaymentAmount { get; set; }
        public DateTime RefundedTime { get; set; }
        public decimal RefundedAmount { get; set; }
    }
}