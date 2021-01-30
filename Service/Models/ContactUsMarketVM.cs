using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public class ContactUsMarketVM
    {
        public Guid ContactUsId { get; set; }
        public string Name { get; set; } = "";
        public string Title { get; set; } = "";
        public string Email { get; set; } = "";
        public bool? Solved { get; set; } = false;
        public bool? Plateform { get; set; }
        public string Phone { get; set; } = "";
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
        public Guid MarketId { get; set; }
        public string Message { get; set; } = "";

    }
}
