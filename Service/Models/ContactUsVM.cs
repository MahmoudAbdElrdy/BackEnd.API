using System;
using System.Collections.Generic;

namespace BackEnd.Service.Models
{
    public partial class ContactUsVM
    {
        public Guid ContactUsId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public bool? Solver { get; set; }
        public bool? Plateform { get; set; }
        public string Phone { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.UtcNow.AddHours(3);
        public Guid Customerid { get; set; }

     //   public virtual CustomerVM Customer { get; set; }
    }
}
