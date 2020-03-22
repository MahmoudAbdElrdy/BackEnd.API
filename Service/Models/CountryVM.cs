using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Service.Models
{
   public class CountryVM
    {
        public string CountryName { get; set; }
        public Guid CountryId { get; set; } = Guid.NewGuid();
    }
}
