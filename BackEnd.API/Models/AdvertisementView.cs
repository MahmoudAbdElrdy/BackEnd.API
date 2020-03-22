using System;
using System.Collections.Generic;

namespace BackEnd.API.Models
{
    public partial class AdvertisementView
    {
        public Guid AdsViewId { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime? CreationDate { get; set; }
        public Guid? AdsId { get; set; }

        public virtual Advertisement Ads { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
