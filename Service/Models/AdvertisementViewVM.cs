using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public partial class AdvertisementViewVM
    {
        public Guid AdsViewId { get; set; } = Guid.NewGuid();
        public Guid Customerid { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
        public Guid? AdsId { get; set; }

        //public virtual CustomerVM Customer { get; set; }
    }
}
