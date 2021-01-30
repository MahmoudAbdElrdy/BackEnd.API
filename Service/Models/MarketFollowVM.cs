using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public class MarketFollowVM
    {
        public Guid MarketCustomerId { get; set; } = Guid.NewGuid();
        public Guid MarketId { get; set; }
        public Guid CustomerId { get; set; }
        public bool Follow { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);

        //public CustomerVM Customer { get; set; }
        //public MarketVM Market { get; set; }
    }
}
