using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Service.DTO
{
    public class AdsCategryDTO
    {
        public ICollection<Models.AdvertisementVM2> ads { get; set; }
        public ICollection<Models.CategoryVM> category { get; set; }
    }
}
