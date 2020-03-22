using System;
using System.Collections.Generic;

namespace BackEnd.API.Models
{
    public partial class AboutUs
    {
        public Guid AboutUsId { get; set; }
        public string Info { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
