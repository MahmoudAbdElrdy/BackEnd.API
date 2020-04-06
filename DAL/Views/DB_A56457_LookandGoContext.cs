using System;
using BackEnd.DAL.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BackEnd.DAL.Models
{
    public partial class DB_A56457_LookandGoContext : DbContext
    {
        public virtual DbQuery<View_City> View_City { get; set; }
        public virtual DbQuery<View_Advertisement> View_Advertisement { get; set; }
    }
}
