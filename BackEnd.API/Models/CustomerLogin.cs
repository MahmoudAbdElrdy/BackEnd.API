using System;
using System.Collections.Generic;

namespace BackEnd.API.Models
{
    public partial class CustomerLogin
    {
        public Guid LoginId { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime? LoginDate { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
