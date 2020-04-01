using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public partial class MarketVM2
    {
        public Guid MarketId { get; set; } = Guid.NewGuid();
        public string MarketName { get; set; }
        public string MarketLogo { get; set; }
        public string MarketAddress { get; set; }
        public string MarketPhone { get; set; }
        public string MarketEmail { get; set; }
        public string MarketInfo { get; set; }
        public string MarketLatlng { get; set; }
        //  public virtual CityVM City { get; set; }
        //  public virtual ICollection<MarketFollowVM> MarketFollow { get; set; }
    }
}
