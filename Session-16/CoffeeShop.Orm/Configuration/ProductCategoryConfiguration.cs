using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Orm.Configuration {
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory> {
        public void Configure(EntityTypeBuilder<ProductCategory> builder) {
            builder.ToTable("ProductCategories");


            builder.HasKey(productCat => productCat.ID);
            builder.Property(productCat => productCat.Code).HasMaxLength(10);
            builder.Property(productCat => productCat.Description).HasMaxLength(30);
            builder.Property(productCat => productCat.ProductType).HasMaxLength(20);
            builder.HasMany(prodCat => prodCat.Products).WithOne(prod => prod.ProductCategory).HasForeignKey(prod => prod.ProductCategoryID);
            //TODO:BE REEEVALUATED.
        }
    }
}
