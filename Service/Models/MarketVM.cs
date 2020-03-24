using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public partial class MarketVM
    {
        public Guid MarketId { get; set; } = Guid.NewGuid();
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
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);

      //  public virtual CityVM City { get; set; }
      //  public virtual ICollection<MarketFollowVM> MarketFollow { get; set; }
    }
}
