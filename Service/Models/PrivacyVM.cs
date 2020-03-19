using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public partial class PrivacyVM
    {
        public Guid PrivacyId { get; set; }
        public string Content { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
    }
}
