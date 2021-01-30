using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public class CategoryVM
    {

        public Guid CategoryId { get; set; } = Guid.NewGuid();
        public string CategoryImage { get; set; } = "";
        public string CategoryName { get; set; } = "";
        public bool? Available { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
        public int Order { get; set; } = 0;

        //public ICollection<AdvertisementCategory> AdvertisementCategory { get; set; }
    }
}
