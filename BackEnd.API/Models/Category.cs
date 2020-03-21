using System;
using System.Collections.Generic;

namespace BackEnd.API.Models
{
    public partial class Category
    {
        public Category()
        {
            Advertisement = new HashSet<Advertisement>();
        }

        public Guid Categoryid { get; set; }
        public string Categoryimage { get; set; }
        public string Categoryname { get; set; }
        public bool? Available { get; set; }
        public DateTime? Creationdate { get; set; }

        public virtual ICollection<Advertisement> Advertisement { get; set; }
    }
}
