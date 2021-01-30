using System;
using System.Collections.Generic;

namespace BackEnd.DAL.Models
{
    public partial class AdvertisementAttach
    {
        public Guid AdsAttachId { get; set; }
        public Guid AdsId { get; set; }
        public DateTime CreationDate { get; set; }
        public bool? Available { get; set; }
        public string Notes { get; set; }
        public string AttachUrl { get; set; }
        public int AttachType { get; set; }

        public virtual Advertisement Ads { get; set; }
    }
}
