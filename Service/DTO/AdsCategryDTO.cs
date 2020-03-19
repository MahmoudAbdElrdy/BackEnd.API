using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Service.DTO
{
    public class AdsCategryDTO
    {
        public virtual ICollection<Models.AdvertisementVM> ads { get; set; }
        public virtual ICollection<Models.CategoryVM> category { get; set; }
    }
}
