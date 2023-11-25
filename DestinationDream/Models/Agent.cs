using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DestinationDream.Models
{
    public class Agent
    {
        public int Id { get; set; }

        public string AgentCode { get; set; }

        public string Name { get; set; }

        public decimal MobileNo { get; set; }

        public bool IsActive { get; set; }
    }
}