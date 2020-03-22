using System;
using System.Collections.Generic;

namespace BackEnd.DAL.Models
{
    public partial class Customer
    {
        public Customer()
        {
            AdvertisementView = new HashSet<AdvertisementView>();
            ContactUs = new HashSet<ContactUs>();
            CustomerLogin = new HashSet<CustomerLogin>();
            MarketFollow = new HashSet<MarketFollow>();
        }

        public Guid CustomerId { get; set; }
        public bool? Plateform { get; set; }
        public string Token { get; set; }
        public Guid? CityId { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<AdvertisementView> AdvertisementView { get; set; }
        public virtual ICollection<ContactUs> ContactUs { get; set; }
        public virtual ICollection<CustomerLogin> CustomerLogin { get; set; }
        public virtual ICollection<MarketFollow> MarketFollow { get; set; }
    }
}
