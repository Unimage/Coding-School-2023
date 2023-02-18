using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configuration {
    public class CustomerConfiguration: IEntityTypeConfiguration<Customer> {

        public void  Configure(EntityTypeBuilder<Customer> builder) {
            //Table name 
            builder.ToTable("Customers");

            //Primary Key
            builder.HasKey(customer => customer.ID);

            builder.Property(customer => customer.Name).HasMaxLength(20).IsRequired();
            builder.Property(customer => customer.Surname).HasMaxLength(20).IsRequired();
            builder.Property(customer => customer.CardNumber).HasMaxLength(20).IsRequired();

            //Constrains : Unique card number
            builder.HasIndex(customer => customer.CardNumber).IsUnique();


        }
    }
}
