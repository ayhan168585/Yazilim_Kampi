using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Northwind.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevFramework.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductMap:IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(@"Products",@"dbo");
            builder.HasKey(p => p.ProductId);

            builder.Property(p => p.ProductId).HasColumnName("ProductId");
            builder.Property(p => p.ProductName).HasColumnName("ProductName");
            builder.Property(p => p.QuantityPerUnit).HasColumnName("QuantityPerUnit");
            builder.Property(p => p.UnitPrice).HasColumnName("UnitPrice");

            
        }
    }
    
}
