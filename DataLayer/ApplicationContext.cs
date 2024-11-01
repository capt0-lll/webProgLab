using DataLayer.Configurations;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }

        public ApplicationContext() { }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectTaskConfiguration());
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("host=localhost;port=5432;database=postgres;username=postgres;password=hellothere;sslmode=prefer");
            }
        }
    }
}
