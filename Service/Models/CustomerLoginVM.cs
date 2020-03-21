using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public partial class CustomerLoginVM
    {
        public Guid LoginId { get; set; } = Guid.NewGuid();
        public Guid Customerid { get; set; }
        public DateTime? LoginDate { get; set; } = DateTime.UtcNow.AddHours(3);

        //public virtual CustomerVM Customer { get; set; }
    }
}
