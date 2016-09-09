using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DropDownListFromViewModel.Models
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Model1> Model1 { get; set; }
        public virtual DbSet<Model2> Model2 { get; set; }
    }
}