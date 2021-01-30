using System;
using System.Collections.Generic;

namespace BackEnd.DAL.Models
{
    public partial class Category
    {
        public Category()
        {
            AdvertisementCategory = new HashSet<AdvertisementCategory>();
        }

        public Guid CategoryId { get; set; }
        public string CategoryImage { get; set; }
        public string CategoryName { get; set; }
        public bool? Available { get; set; }
        public DateTime? CreationDate { get; set; }
        public int Order { get; set; }

        public virtual ICollection<AdvertisementCategory> AdvertisementCategory { get; set; }
    }
}
