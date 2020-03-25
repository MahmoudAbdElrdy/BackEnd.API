using System;
using System.Collections.Generic;

namespace BackEnd.API.Models
{
    public partial class Country
    {
        public Country()
        {
            City = new HashSet<City>();
        }

        public string CountryName { get; set; }
        public Guid CountryId { get; set; }

        public virtual ICollection<City> City { get; set; }
    }
}
