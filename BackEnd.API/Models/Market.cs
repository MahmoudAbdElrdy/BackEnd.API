﻿using System;
using System.Collections.Generic;

namespace BackEnd.API.Models
{
    public partial class Market
    {
        public Market()
        {
            MarketFollow = new HashSet<MarketFollow>();
        }

        public Guid MarketId { get; set; }
        public string MarketName { get; set; }
        public int? MarketLatlng { get; set; }
        public string MarketLogo { get; set; }
        public string MarketAddress { get; set; }
        public string MarketPhone { get; set; }
        public string MarketEmail { get; set; }
        public string MarketPassword { get; set; }
        public string MarketInfo { get; set; }
        public bool Plateform { get; set; }
        public Guid CityId { get; set; }
        public string Token { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool Available { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<MarketFollow> MarketFollow { get; set; }
    }
}
