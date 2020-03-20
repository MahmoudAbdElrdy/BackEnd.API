using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public partial class MarketFollowVM
    {
        public Guid Marketid { get; set; }
        public Guid Customerid { get; set; }
        public bool Follow { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
        public int MarketCustomerId { get; set; }

        //public virtual CustomerVM Customer { get; set; }
        //public virtual MarketVM Market { get; set; }
    }
}
