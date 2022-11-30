using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ValueObjectWithInheritance
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseClassTypeConfiguration());
        }
    }


    public class CourseClassTypeConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(p => p.Id);
            builder.OwnsOne<PersonContainer>("_personContainer", navigationBuilder =>
            {
                navigationBuilder.Property<string>("_firstName").HasColumnName("FirstName").IsRequired();
                navigationBuilder.Property<string>("_lastName").HasColumnName("LastName").IsRequired();
                navigationBuilder.Property("_type").HasConversion<string>();
                navigationBuilder.Property<string>("_subjectArea").HasColumnName("SubjectArea");
                navigationBuilder.Property<string>("_department").HasColumnName("Department");


            });
        }

    }
}
