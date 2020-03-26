﻿using System;
using System.Collections.Generic;

namespace BackEnd.DAL.Models
{
    public partial class Category
    {
        public Category()
        {
            Advertisement = new HashSet<Advertisement>();
        }

        public Guid CategoryId { get; set; }
        public string CategoryImage { get; set; }
        public string CategoryName { get; set; }
        public bool? Available { get; set; }
        public DateTime? CreationDate { get; set; }
        public int Order { get; set; }

        public virtual ICollection<Advertisement> Advertisement { get; set; }
    }
}
