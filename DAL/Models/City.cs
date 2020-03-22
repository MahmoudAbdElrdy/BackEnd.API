using System;
using System.Collections.Generic;

namespace BackEnd.DAL.Models
{
    public partial class City
    {
        public City()
        {
            Advertisement = new HashSet<Advertisement>();
            AdvertisementUpdate = new HashSet<AdvertisementUpdate>();
            Customer = new HashSet<Customer>();
            Market = new HashSet<Market>();
        }

        public Guid CityId { get; set; }
        public string CityName { get; set; }
        public Guid CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Advertisement> Advertisement { get; set; }
        public virtual ICollection<AdvertisementUpdate> AdvertisementUpdate { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<Market> Market { get; set; }
    }
}
