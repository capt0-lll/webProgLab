using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Configurations
{
    internal class ProjectTaskConfiguration : IEntityTypeConfiguration<ProjectTask>
    {
        public void Configure(EntityTypeBuilder<ProjectTask> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Description).HasMaxLength(300);
            builder.Property(e => e.Status).HasMaxLength(15);

            builder.HasOne(e => e.Project)
                .WithMany()
                .HasForeignKey(o => o.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);
                
            builder.HasOne(e => e.Employee)
                .WithMany()
                .HasForeignKey(o => o.EmployeeId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
