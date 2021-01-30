using System;
using System.Collections.Generic;

namespace BackEnd.Service.DTO
{
    public class MarketLoginDTO
    {
        public string MarketEmail { get; set; }
        public string MarketPassword { get; set; }
        public string Token { get; set; }
    }
}
