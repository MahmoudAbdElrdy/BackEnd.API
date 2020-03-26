using System;
using System.Collections.Generic;

namespace BackEnd.DAL.Models
{
    public partial class ContactUsMarket
    {
        public Guid ContactUsId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public bool? Solved { get; set; }
        public bool? Plateform { get; set; }
        public string Phone { get; set; }
        public DateTime? CreationDate { get; set; }
        public Guid MarketId { get; set; }
        public string Message { get; set; }

        public virtual Market Market { get; set; }
    }
}
