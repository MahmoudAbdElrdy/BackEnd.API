using System;
using System.Collections.Generic;

namespace BackEnd.DAL.Models
{
    public partial class AdvertisementOpen
    {
        public Guid AdsOpenId { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime? CreationDate { get; set; }
        public Guid? AdsId { get; set; }

        public virtual Advertisement Ads { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
