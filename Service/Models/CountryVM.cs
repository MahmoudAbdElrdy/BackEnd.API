using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Service.Models
{
   public class CountryVM
    {
        public string CountryName { get; set; }
        public Guid CountryId { get; set; } = Guid.NewGuid();
        public int Order { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
        public bool? Available { get; set; } = true;
    }
}
