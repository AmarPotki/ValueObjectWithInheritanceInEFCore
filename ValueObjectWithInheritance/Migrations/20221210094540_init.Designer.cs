﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ValueObjectWithInheritance;

#nullable disable

namespace ValueObjectWithInheritance.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20221210094540_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ValueObjectWithInheritance.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ValueObjectWithInheritance.Entities.Course", b =>
                {
                    b.OwnsOne("ValueObjectWithInheritance.Entities.PersonContainer", "_personContainer", b1 =>
                        {
                            b1.Property<int>("CourseId")
                                .HasColumnType("int");

                            b1.Property<string>("_department")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Department");

                            b1.Property<string>("_firstName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("_lastName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("LastName");

                            b1.Property<string>("_subjectArea")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("SubjectArea");

                            b1.Property<string>("_type")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("PersonType");

                            b1.HasKey("CourseId");

                            b1.ToTable("Courses");

                            b1.WithOwner()
                                .HasForeignKey("CourseId");
                        });

                    b.Navigation("_personContainer");
                });
#pragma warning restore 612, 618
        }
    }
}
