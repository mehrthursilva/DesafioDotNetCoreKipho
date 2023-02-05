using kipho.api.data.Mapping;
using kipho.api.domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kipho.api.data.Context
{
    public class MyContext: DbContext
    {
        public DbSet <Products> Products { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Products>(new ProductMaps().Configure);
        }
    }
}
