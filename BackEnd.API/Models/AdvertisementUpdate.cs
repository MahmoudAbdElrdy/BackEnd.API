using System;
using System.Collections.Generic;

namespace BackEnd.API.Models
{
    public partial class AdvertisementUpdate
    {
        public Guid AdsId { get; set; }
        public Guid Cityid { get; set; }
        public int? AdsType { get; set; }
        public string AdsText { get; set; }
        public string AdsImage { get; set; }
        public string AdsVideo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Available { get; set; }
        public bool? Special { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual City City { get; set; }
    }
}
