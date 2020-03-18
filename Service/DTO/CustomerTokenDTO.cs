using System;
using System.Collections.Generic;

namespace BackEnd.Service.DTO
{
    public partial class CustomerTokenDTO
    {
        public Guid CustomerId { get; set; }
        public string Token { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
    }
}
