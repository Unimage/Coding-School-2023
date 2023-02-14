using Session_27;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Session_27.Model.EF.Configurations
{
    public class ServiceTaskConfiguration : IEntityTypeConfiguration<ServiceTask>
    {
        public void Configure(EntityTypeBuilder<ServiceTask> builder)
        {
            // Table Name
            builder.ToTable("ServiceTasks");

            // Primary Key
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(t => t.Code).HasMaxLength(50).IsRequired();
            builder.Property(t => t.Description).HasMaxLength(100).IsRequired();
            builder.Property(t => t.Hours).HasPrecision(7, 2).IsRequired();

            // Relations
        }
    }
}
