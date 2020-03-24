using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public partial class ContactUsVM
    {
        public Guid ContactUsId { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public bool? Solved { get; set; }
        public bool? Plateform { get; set; }
        public string Phone { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
        public Guid CustomerId { get; set; }
        public string Message { get; set; }

        //public virtual CustomerVM Customer { get; set; }
    }
}
