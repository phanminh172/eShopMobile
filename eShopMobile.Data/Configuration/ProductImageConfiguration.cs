using eShopMobile.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMobile.Data.Configuration
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable("ProductImages");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.ImagePath).IsRequired(true);

            builder.HasOne(x => x.Product).WithMany(x => x.ProductImages).HasForeignKey(x => x.ProductId);
        }
    }
}
