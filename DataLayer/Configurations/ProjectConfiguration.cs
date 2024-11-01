using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Configurations
{
    internal class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Name).HasMaxLength(30);
            builder.Property(e => e.Description).HasMaxLength(500);
            builder.Property(e => e.StartDate).HasConversion(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Utc));
            builder.Property(e => e.EndDate).HasConversion(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Utc));
        }
    }
}
