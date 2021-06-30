using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public class AdvertisementAttachVM
    {
        public Guid AdsAttachId { get; set; } = Guid.NewGuid();
        public Guid? AdsId { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
        public bool? Available { get; set; } = true;
        public string Notes { get; set; } = "";
        public string AttachUrl { get; set; } = "";
        public int? AttachType { get; set; }

        //public AdvertisementVM Ads { get; set; }
    }
    
    public class AdvertisementAttachFileVM
    {
        public Guid AdsAttachId { get; set; } = Guid.NewGuid();
        public Guid AdsId { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
        public bool? Available { get; set; } = true;
        public string Notes { get; set; } = "";
        public string AttachUrl { get; set; } = "";
        public int AttachType { get; set; }
        public Microsoft.AspNetCore.Http.IFormFile File { get; set; }
        //public AdvertisementVM Ads { get; set; }
    }
}
