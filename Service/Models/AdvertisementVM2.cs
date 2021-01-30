using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public class AdvertisementVM2
    {
        public Guid AdsId { get; set; } = Guid.NewGuid();
        public int? AdsType { get; set; }
        public string AdsText { get; set; } = "";
        public string AdsImage { get; set; } = "";
        public string AdsVideo { get; set; } = "";
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Available { get; set; } = false;
        public bool? Special { get; set; } = false;
        public bool? WaitingUpdate { get; set; } = false;
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
        public Guid? MarketId { get; set; }
        public string AdsName { get; set; } = "";
        public MarketVM2 Market { get; set; }
        //public CityVM City { get; set; }
    }
}
