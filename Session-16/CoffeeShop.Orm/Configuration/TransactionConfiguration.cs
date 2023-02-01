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
            builder.Property(transaction => transaction.TotalPrice).HasPrecision(6, 2);
            builder.Property(transaction => transaction.TotalCost).HasPrecision(6, 2);
            builder.Property(transaction => transaction.PaymentMethod).IsRequired();

            
            builder.HasOne(transaction => transaction.Employee).WithMany(employee => employee.TransactionList).HasForeignKey(transaction => transaction.EmployeeID);
            builder.HasOne(transaction => transaction.Customer).WithMany(customer => customer.TransactionList).HasForeignKey(transaction => transaction.CustomerID);
            builder.HasMany(transaction => transaction.TransactionLines).WithOne(transactionLine => transactionLine.Transaction).HasForeignKey(transactionLine => transactionLine.ID);
            //builder.HasMany(transaction => transaction.TransactionLines);


        }
    }
}
