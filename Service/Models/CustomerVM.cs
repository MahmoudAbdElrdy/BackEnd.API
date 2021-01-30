using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public class CustomerVM
    {
        public Guid CustomerId { get; set; } = Guid.NewGuid();
        public bool? Plateform { get; set; }
        public string Token { get; set; } = "";
        public Guid? CityId { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);

        //public CityVM City { get; set; }
        //public ICollection<AdvertisementViewVM> AdvertisementView { get; set; }
        //public ICollection<CustomerLoginVM> CustomerLogin { get; set; }
        //public ICollection<MarketFollowVM> MarketFollow { get; set; }
    }
}
