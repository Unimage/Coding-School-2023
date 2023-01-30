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

            builder.Property(transaction => transaction.Date);

            builder.Property(transaction => transaction.TotalPrice).HasColumnType("decimal(6,2)").HasPrecision(6, 2);
            builder.Property(transaction => transaction.TotalCost).HasColumnType("decimal(6,2)").HasPrecision(6, 2);

            builder.Property(transaction => transaction.PaymentMethod).IsRequired();

            //Constraints
            builder.HasOne(transaction => transaction.Employee).WithOne(employee => employee.Transaction).HasForeignKey<Transaction>(transaction => transaction.ID);
            builder.HasOne(transaction => transaction.Customer).WithOne(customer => customer.Transaction).HasForeignKey<Transaction>(transaction => transaction.ID);
            builder.HasMany(transaction => transaction.TransactionLines).WithOne(transactionLine => transactionLine.Transaction).HasForeignKey(transactionLine => transactionLine.ID);
            //TODO:EVAL ABOVE 3 


        }
    }
}
