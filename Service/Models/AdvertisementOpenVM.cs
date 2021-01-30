using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public class AdvertisementOpenVM
    {
        public Guid AdsopenId { get; set; } = Guid.NewGuid();
        public Guid CustomerId { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
        public Guid? AdsId { get; set; }

    }
}
