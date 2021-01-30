using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public class PrivacyVM
    {
        public Guid PrivacyId { get; set; } = Guid.NewGuid();
        public string Content { get; set; } = "";
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
        public bool? Available { get; set; } = true;
    }
}
