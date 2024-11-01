using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Configurations
{
    public class EmployeeConfiguration:IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.FirstName).HasMaxLength(30);
            builder.Property(e => e.LastName).HasMaxLength(30);
            builder.Property(e => e.Position).HasMaxLength(30);
        }
    }
}
