using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.DAL.Views
{
   public class View_Advertisement
    {
        public Guid AdsId { get; set; } = Guid.NewGuid();
       
        public int? AdsType { get; set; }
        public string AdsText { get; set; }
        public string AdsImage { get; set; }
        public string AdsVideo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Available { get; set; } = false;
        public bool? Special { get; set; } = false;
        public bool? WaitingUpdate { get; set; } = false;
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
       
        public string CategoryName { get; set; }
        public string CityName { get; set; }
        public string MarketName { get; set; }
        public int CountAdvertismenOpen { get; set; }
        public int CountAdvertismenView { get; set; }
        public int CountCustomerOpen { get; set; }
        public int CountCustomerView { get; set; }
        public Guid CategoryId { get; set; }
        public Guid CityId { get; set; }
        public Guid MarketId { get; set; }

    }
}
