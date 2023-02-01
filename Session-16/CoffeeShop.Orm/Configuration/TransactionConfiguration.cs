using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Model;

namespace CoffeeShop.Orm.Configuration {
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction> {
        public void Configure(EntityTypeBuilder<Transaction> builder) {
            builder.ToTable("Transactions");

            builder.HasKey(transaction => transaction.ID);

            builder.Property(transaction => transaction.Date).IsRequired();
            builder.Property(transaction => transaction.TotalPrice).HasPrecision(6, 2);
            builder.Property(transaction => transaction.TotalCost).HasPrecision(6, 2);
            builder.Property(transaction => transaction.PaymentMethod).IsRequired();

            builder.HasMany(transaction => transaction.TransactionLines);


        }
    }
}
