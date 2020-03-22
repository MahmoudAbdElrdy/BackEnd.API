using System;
using System.Collections.Generic;

namespace BackEnd.API.Models
{
    public partial class MarketFollow
    {
        public Guid MarketCustomerId { get; set; }
        public Guid MarketId { get; set; }
        public Guid CustomerId { get; set; }
        public bool Follow { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Market Market { get; set; }
    }
}
