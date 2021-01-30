using System;
using System.Collections.Generic;

namespace BackEnd.DAL.Models
{
    public partial class AdvertisementCity
    {
        public Guid AdsCityId { get; set; }
        public Guid AdsId { get; set; }
        public Guid CityId { get; set; }
        public DateTime CreationDate { get; set; }
        public bool? Available { get; set; }
        public string Notes { get; set; }

        public virtual Advertisement Ads { get; set; }
        public virtual City City { get; set; }
    }
}
