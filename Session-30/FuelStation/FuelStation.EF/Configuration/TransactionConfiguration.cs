using FuelStation.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configuration {
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction> {

        public void Configure(EntityTypeBuilder<Transaction> builder) {
            //Table name 
            builder.ToTable("Transactions");

            //Primary Key
            builder.HasKey(transaction => transaction.ID);


            builder.Property(transaction => transaction.Date).IsRequired();
            builder.Property(transaction => transaction.EmployeeID).IsRequired();
            builder.Property(transaction => transaction.CustomerID).IsRequired();
            builder.Property(transaction => transaction.PaymentMethod).HasMaxLength(20).IsRequired();
            builder.Property(transaction => transaction.TotalValue).HasPrecision(9, 2).IsRequired();

            //RELATIONS
            builder.HasOne(transaction => transaction.Customer)
               .WithMany(customer => customer.Transactions)
               .HasForeignKey(transaction => transaction.CustomerID)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(transaction => transaction.Employee)
                .WithMany(employee => employee.Transactions)
                .HasForeignKey(transaction => transaction.EmployeeID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
