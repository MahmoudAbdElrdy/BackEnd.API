using System;
using System.Collections.Generic;

namespace BackEnd.DAL.Models
{
    public partial class AdvertisementView
    {
        public Guid AdsId { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
