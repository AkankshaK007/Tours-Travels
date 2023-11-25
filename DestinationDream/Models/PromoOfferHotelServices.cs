using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DestinationDream.Models
{
    public class PromoOfferHotelServices
    {
        public int Id { get; set; }
        public int PromoOfferId { get; set; }
        public int HotelServicesId { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPer { get; set; }
        public decimal FinalServicesPrice { get; set; }
        public string Description { get; set; }

    }
}