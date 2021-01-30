using System;
using System.Collections.Generic;

namespace BackEnd.DAL.Models
{
    public partial class Advertisement
    {
        public Advertisement()
        {
            AdvertisementAttach = new HashSet<AdvertisementAttach>();
            AdvertisementCategory = new HashSet<AdvertisementCategory>();
            AdvertisementCity = new HashSet<AdvertisementCity>();
            AdvertisementOpen = new HashSet<AdvertisementOpen>();
            AdvertisementUpdate = new HashSet<AdvertisementUpdate>();
            AdvertisementView = new HashSet<AdvertisementView>();
        }

        public Guid AdsId { get; set; }
        public int? AdsType { get; set; }
        public string AdsText { get; set; }
        public string AdsImage { get; set; }
        public string AdsVideo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Available { get; set; }
        public bool? Special { get; set; }
        public bool? WaitingUpdate { get; set; }
        public DateTime? CreationDate { get; set; }
        public Guid? MarketId { get; set; }
        public string AdsName { get; set; }

        public virtual Market Market { get; set; }
        public virtual ICollection<AdvertisementAttach> AdvertisementAttach { get; set; }
        public virtual ICollection<AdvertisementCategory> AdvertisementCategory { get; set; }
        public virtual ICollection<AdvertisementCity> AdvertisementCity { get; set; }
        public virtual ICollection<AdvertisementOpen> AdvertisementOpen { get; set; }
        public virtual ICollection<AdvertisementUpdate> AdvertisementUpdate { get; set; }
        public virtual ICollection<AdvertisementView> AdvertisementView { get; set; }
    }
}
