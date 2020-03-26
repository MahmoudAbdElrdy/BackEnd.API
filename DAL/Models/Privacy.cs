using System;
using System.Collections.Generic;

namespace BackEnd.DAL.Models
{
    public partial class Privacy
    {
        public Guid PrivacyId { get; set; }
        public string Content { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? Available { get; set; }
    }
}
