using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public partial class AboutUsVM
    {
        public Guid AboutUsId { get; set; }
        public string Info { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
    }
}
