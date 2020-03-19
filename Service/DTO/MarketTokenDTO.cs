using System;
using System.Collections.Generic;

namespace BackEnd.Service.DTO
{
    public partial class MarketTokenDTO
    {
        public Guid MarketId { get; set; }
        public string Token { get; set; }
    }
}
