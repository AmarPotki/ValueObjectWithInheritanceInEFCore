using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ValueObjectWithInheritance.Entities;

namespace ValueObjectWithInheritance.Configurations;

public class CourseClassTypeConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.HasKey(p => p.Id);
        builder.OwnsOne<PersonContainer>("_personContainer", navigationBuilder =>
        {
            navigationBuilder.Property<string>("_firstName").HasColumnName("FirstName").IsRequired();
            navigationBuilder.Property<string>("_lastName").HasColumnName("LastName").IsRequired();
            navigationBuilder.Property("_type").HasConversion<string>().HasColumnName("PersonType");
            navigationBuilder.Property<string>("_subjectArea").HasColumnName("SubjectArea");
            navigationBuilder.Property<string>("_department").HasColumnName("Department");


        });
    }

}