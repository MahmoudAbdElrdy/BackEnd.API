using System;
using System.Collections.Generic;

namespace BackEnd.DAL.Models
{
    public partial class AdvertisementOpen
    {
        public Guid AdsId { get; set; }
        public Guid Customerid { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
