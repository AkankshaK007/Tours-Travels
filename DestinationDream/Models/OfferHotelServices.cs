using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DestinationDream.Models
{
    public class OfferHotelServices
    {
        public int Id { get; set; }
        public int OfferId { get; set; }
        public int HotelServicesId { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPer { get; set; }
        public decimal FinalServicesPrice { get; set; }
        public string Description { get; set; }
      
    }
}