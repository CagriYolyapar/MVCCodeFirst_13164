using MVCCodeFirst_1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_1.Models.ContextClasses
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Category>  Categories { get; set; }
    }
}