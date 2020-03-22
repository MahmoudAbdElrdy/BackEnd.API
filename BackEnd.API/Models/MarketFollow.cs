using System;
using System.Collections.Generic;

namespace BackEnd.API.Models
{
    public partial class MarketFollow
    {
        public Guid Marketid { get; set; }
        public Guid Customerid { get; set; }
        public bool Follow { get; set; }
        public DateTime? CreationDate { get; set; }
        public int MarketCustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Market Market { get; set; }
    }
}
