using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public class CityVM
    {

        public Guid CityId { get; set; } = Guid.NewGuid();
        public string CityName { get; set; } = "";
        public Guid CountryId { get; set; }
        public int Order { get; set; } = 0;
        public bool? Available { get; set; } = true;
        public string CountryName { get; set; } = "";
    }
}
