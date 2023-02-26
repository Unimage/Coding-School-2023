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
    public class ItemConfiguration : IEntityTypeConfiguration<Item> {

        public void Configure(EntityTypeBuilder<Item> builder) {
            //Table name 
            builder.ToTable("Items");

            //Primary Key
            builder.HasKey(item => item.ID);

            builder.Property(item => item.Code).HasMaxLength(6);
            builder.Property(item => item.Description).HasMaxLength(30);
            builder.Property(item => item.ItemType).HasMaxLength(20).IsRequired();
            builder.Property(item => item.Price).HasPrecision(7, 2);
            builder.Property(item => item.Cost).HasPrecision(7, 2);
            builder.HasIndex(item => item.Code).IsUnique();

        }
    }
}
