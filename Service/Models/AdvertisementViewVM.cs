using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public class AdvertisementViewVM
    {
        public Guid AdsViewId { get; set; } = Guid.NewGuid();
        public Guid CustomerId { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
        public Guid? AdsId { get; set; }

        //public CustomerVM Customer { get; set; }
    }
}
