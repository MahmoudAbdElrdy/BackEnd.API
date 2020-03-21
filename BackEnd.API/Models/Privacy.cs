using System;
using System.Collections.Generic;

namespace BackEnd.API.Models
{
    public partial class Privacy
    {
        public Guid PrivacyId { get; set; }
        public string Content { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
