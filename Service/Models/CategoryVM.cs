using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public partial class CategoryVM
    {

        public Guid CategoryId { get; set; }
        public Guid MarketId { get; set; }
        public string CategoryImage { get; set; }
        public string CategoryName { get; set; }
        public bool? Available { get; set; }
        public DateTime? CreationDate { get; set; }

       // public virtual MarketVM Market { get; set; }
      //  public virtual ICollection<AdvertisementVM> Advertisement { get; set; }
    }
}
