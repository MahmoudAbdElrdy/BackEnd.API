using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public class AdvertisementCityVM
    {
        public Guid? AdsCityId { get; set; } = Guid.NewGuid();
        public Guid? AdsId { get; set; }
        public Guid? CityId { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
        public bool? Available { get; set; } = true;
        public string Notes { get; set; } = "";

        //public AdvertisementVM Ads { get; set; }
        //public CityVM City { get; set; }
    }
    
    public class AdvertisementCityIncloudVM
    {
        public Guid AdsCityId { get; set; } = Guid.NewGuid();
        public Guid AdsId { get; set; }
        public Guid CityId { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
        public bool? Available { get; set; } = true;
        public string Notes { get; set; } = "";

        //public AdvertisementVM Ads { get; set; }
        public CityVM City { get; set; }
    }
}
