using kipho.api.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kipho.api.data.Mapping
{
    public class ProductMaps : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            
            builder.ToTable("Products");

            builder.HasKey(u => u.id);

            builder.Property(u => u.price).HasPrecision(18,2);

            //builder.Property(u => u.Name)
            //       .IsRequired()
            //       .HasMaxLength(60);

            //builder.Property(u => u.Email)
            //       .HasMaxLength(100);
        }
    }
}

//"createdAt": "2022-05-20T00:31:08.822Z",
//  "name": "Incredible Plastic Pants",
//  "price": "827.00",
//  "brand": "Hauck - Johnson",
//  "updatedAt": "2022-05-22T02:31:08.822Z",
//  "id": "1"
