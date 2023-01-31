using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Orm.Configuration {
        public class EmployeeConfiguration : IEntityTypeConfiguration<Employee> {
            public void Configure(EntityTypeBuilder<Employee> builder) {
                builder.ToTable("Employees");

                builder.HasKey(emp => emp.ID);

                builder.Property(emp => emp.Name).HasMaxLength(20);
                builder.Property(emp => emp.Surname).HasMaxLength(20);
                builder.Property(emp => emp.EmployeeType).HasMaxLength(20);
                builder.Property(emp => emp.Salary).HasColumnType("decimal(6,2)").HasPrecision(6, 2);

                //TODO:TO BE EVALUATED.
                builder.HasOne(employee => employee.Transaction).WithOne(transaction => transaction.Employee).HasForeignKey<Transaction>(transaction => transaction.ID);

            }
        }
    }

