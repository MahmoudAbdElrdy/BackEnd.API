using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public class CustomerLoginVM
    {
        public Guid LoginId { get; set; } = Guid.NewGuid();
        public Guid CustomerId { get; set; }
        public DateTime? LoginDate { get; set; } = DateTime.UtcNow.AddHours(3);

        //public CustomerVM Customer { get; set; }
    }
}
