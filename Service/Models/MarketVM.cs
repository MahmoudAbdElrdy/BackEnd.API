using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public class MarketVM
    {
        public Guid MarketId { get; set; } = Guid.NewGuid();
        public string MarketName { get; set; } = "";
        public string MarketLogo { get; set; } = "";
        public string MarketAddress { get; set; } = "";
        public string MarketPhone { get; set; } = "";
        public string MarketEmail { get; set; } = "";
        public string MarketPassword { get; set; } = "";
        public string MarketInfo { get; set; } = "";
        public bool Plateform { get; set; }
        public Guid CityId { get; set; }
        public string Token { get; set; } = "";
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
        public string MarketLatlng { get; set; } = "";
        public bool Available { get; set; } = false;
        public string InstagramUrl { get; set; }
        public string SnapchatUrl { get; set; }
        public string WebSitUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        //  public CityVM City { get; set; }
        //  public ICollection<MarketFollowVM> MarketFollow { get; set; }
    }

    public class MarketImageVM
    {
        public Guid MarketId { get; set; } = Guid.NewGuid();
        public string MarketName { get; set; } = "";
        public string MarketLogo { get; set; } = "";
        public string MarketAddress { get; set; } = "";
        public string MarketPhone { get; set; } = "";
        public string MarketEmail { get; set; } = "";
        public string MarketPassword { get; set; } = "";
        public string MarketInfo { get; set; } = "";
        public bool Plateform { get; set; }
        public Guid CityId { get; set; }
        public string Token { get; set; } = "";
        public Microsoft.AspNetCore.Http.IFormFile Image { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
        public string MarketLatlng { get; set; } = "";
        public bool Available { get; set; } = false;
        public string InstagramUrl { get; set; }
        public string SnapchatUrl { get; set; }
        public string WebSitUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        //  public CityVM City { get; set; }
        //  public ICollection<MarketFollowVM> MarketFollow { get; set; }
    }
}
