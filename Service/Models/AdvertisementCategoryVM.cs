using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public class AdvertisementCategoryVM
    {
        public Guid AdsCategoryId { get; set; } = Guid.NewGuid();
        public Guid AdsId { get; set; }
        public Guid CategoryId { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
        public bool? Available { get; set; } = true;
        public string Notes { get; set; } = "";

        //public AdvertisementVM Ads { get; set; }
        //public CategoryVM Category { get; set; }
    }
}
