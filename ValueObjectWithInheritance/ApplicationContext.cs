using Microsoft.EntityFrameworkCore;
using ValueObjectWithInheritance.Configurations;
using ValueObjectWithInheritance.Entities;

namespace ValueObjectWithInheritance
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=CourseDB;User Id=sa;Password=sa;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseClassTypeConfiguration());
        }
    }
}
