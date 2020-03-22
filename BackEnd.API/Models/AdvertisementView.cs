using System;
using System.Collections.Generic;

namespace BackEnd.API.Models
{
    public partial class AdvertisementView
    {
        public Guid AdsId { get; set; }
        public Guid Customerid { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
