using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public partial class CustomerVM
    {
        public Guid CustomerId { get; set; }
        public bool? Plateform { get; set; }
        public string Token { get; set; }
        public Guid? Cityid { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);

        public virtual CityVM City { get; set; }
      //  public virtual ICollection<AdvertisementViewVM> AdvertisementView { get; set; }
       // public virtual ICollection<CustomerLoginVM> CustomerLogin { get; set; }
       // public virtual ICollection<MarketFollowVM> MarketFollow { get; set; }
    }
}
