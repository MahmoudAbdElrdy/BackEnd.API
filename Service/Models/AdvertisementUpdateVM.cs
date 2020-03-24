using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public partial class AdvertisementUpdateVM
    {
        public Guid AdsUpdateId { get; set; } = Guid.NewGuid();
        public Guid CityId { get; set; }
        public int? AdsType { get; set; }
        public string AdsText { get; set; }
        public string AdsImage { get; set; }
        public string AdsVideo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Available { get; set; }
        public bool? Special { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
        public Guid? AdsId { get; set; }

        //public virtual CityVM City { get; set; }
    }
}
