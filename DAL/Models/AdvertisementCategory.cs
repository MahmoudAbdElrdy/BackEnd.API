using System;
using System.Collections.Generic;

namespace BackEnd.DAL.Models
{
    public partial class AdvertisementCategory
    {
        public Guid AdsCategoryId { get; set; }
        public Guid AdsId { get; set; }
        public Guid CategoryId { get; set; }
        public DateTime CreationDate { get; set; }
        public bool? Available { get; set; }
        public string Notes { get; set; }

        public virtual Advertisement Ads { get; set; }
        public virtual Category Category { get; set; }
    }
}
