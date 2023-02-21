using FuelStation.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStation.Model.Enumerations;

namespace FuelStation.EF.Configuration {
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee> {

        public void Configure(EntityTypeBuilder<Employee> builder) {
            //Table name 
            builder.ToTable("Employees");

            //Primary Key
            builder.HasKey(employee => employee.ID);

            builder.Property(employee => employee.Name).HasMaxLength(20).IsRequired();
            builder.Property(employee => employee.Surname).HasMaxLength(20).IsRequired();
            builder.Property(employee => employee.username).HasMaxLength(20);
            builder.Property(employee => employee.password).HasMaxLength(256);
            builder.Property(employee => employee.EmployeeType).HasMaxLength(20).IsRequired();
            builder.Property(employee => employee.HireDateStart).IsRequired();
            builder.Property(employee => employee.HireDateEnd);
            builder.Property(employee => employee.SallaryPerMonth).HasPrecision(7,2).IsRequired();
        }
    }
}
