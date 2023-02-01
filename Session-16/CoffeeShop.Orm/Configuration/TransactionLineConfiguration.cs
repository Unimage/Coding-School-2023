using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Orm.Configuration
{
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.ToTable("TransactionLine");

            builder.HasKey(transLine => transLine.ID);

            builder.Property(transLine => transLine.ID);

            builder.Property(transLine => transLine.Quantity);
            builder.Property(transLine => transLine.Price).HasColumnType("decimal(6,2)").HasPrecision(6, 2);
            builder.Property(transLine => transLine.Discount).HasColumnType("decimal(6,2)").HasPrecision(6, 2);
            builder.Property(transLine => transLine.TotalPrice).HasColumnType("decimal(6,2)").HasPrecision(6, 2);

            //TODO:EVALUATE BELOW
            builder.HasOne(transactionLine => transactionLine.Product).WithMany(item => item.TransactionLines).HasForeignKey(transactionLine => transactionLine.ProductID);
        }
    }
}
