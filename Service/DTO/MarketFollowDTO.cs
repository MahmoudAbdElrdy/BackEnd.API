using System;
using System.Collections.Generic;

namespace BackEnd.Service.DTO
{
    public partial class MarketFollowDTO
    {
        public Guid Marketid { get; set; }
        public Guid Customerid { get; set; }
        public bool Follow { get; set; }
    }
}
