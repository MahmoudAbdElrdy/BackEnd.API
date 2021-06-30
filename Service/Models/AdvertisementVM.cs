using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public class AdvertisementVM
    {
        public Guid AdsId { get; set; } = Guid.NewGuid();

        public int? AdsType { get; set; }
        public string AdsText { get; set; } = "";
        public string AdsImage { get; set; } = "";
        public string AdsVideo { get; set; } = "";
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Available { get; set; } = true;
        public bool? Special { get; set; } = false;
        public bool? WaitingUpdate { get; set; } = false;
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
        public string MarketName { get; set; } = "";
        public int CountAdvertismenOpen { get; set; }
        public int CountAdvertismenView { get; set; }
        public int CountCustomerOpen { get; set; }
        public int CountCustomerView { get; set; }
        public Guid MarketId { get; set; }
        public string AdsName { get; set; } = "";

        //public MarketVM Market { get; set; }
        //public CityVM City { get; set; }
    }

    public class AdvertisementImageVM
    {
        public Guid AdsId { get; set; } = Guid.NewGuid();

        public int? AdsType { get; set; }
        public string AdsText { get; set; } = "";
        public string AdsImage { get; set; } = "";
        public string AdsVideo { get; set; } = "";
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Available { get; set; } = true;
        public bool? Special { get; set; } = false;
        public bool? WaitingUpdate { get; set; } = false;
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);

        public string CategoryName { get; set; } = "";
        public string CityName { get; set; } = "";
        public string MarketName { get; set; } = "";
        public int CountAdvertismenOpen { get; set; }
        public int CountAdvertismenView { get; set; }
        public int CountCustomerOpen { get; set; }
        public int CountCustomerView { get; set; }
        public Guid MarketId { get; set; }
        public string AdsName { get; set; } = "";

        public Microsoft.AspNetCore.Http.IFormFile Image { get; set; }
        public Microsoft.AspNetCore.Http.IFormFile Video { get; set; }
    }

    public class AdvertisementIncloudVM
    {
        public Guid AdsId { get; set; } = Guid.NewGuid();
        public int? AdsType { get; set; }
        public string AdsText { get; set; } = "";
        public string AdsImage { get; set; } = "";
        public string AdsVideo { get; set; } = "";
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Available { get; set; } = true;
        public bool? Special { get; set; }
        public bool? WaitingUpdate { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
        public Guid? MarketId { get; set; }
        public string AdsName { get; set; } = "";

        public ICollection<AdvertisementCategoryVM> AdvertisementCategory { get; set; }
        public ICollection<AdvertisementAttachVM> AdvertisementAttach { get; set; }
        public ICollection<AdvertisementCityIncloudVM> AdvertisementCity { get; set; }
    }
}
