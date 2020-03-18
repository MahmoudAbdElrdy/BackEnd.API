using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public partial class CityVM
    {

        public Guid CityId { get; set; }
        public string CityName { get; set; }
        public Guid Countryid { get; set; }

        public virtual CountryVM Country { get; set; }
    }
}
