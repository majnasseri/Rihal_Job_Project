// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentsBlazorApp.Models;

#nullable disable

namespace StudentsBlazorApp.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220606124936_updatedStudents")]
    partial class updatedStudents
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("StudentsBlazorApp.Models.classes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("class_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("classes");
                });

            modelBuilder.Entity("StudentsBlazorApp.Models.countries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("countries");
                });

            modelBuilder.Entity("StudentsBlazorApp.Models.students", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("_classId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("countryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("date_of_birth")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("_classId");

                    b.HasIndex("countryId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("StudentsBlazorApp.Models.students", b =>
                {
                    b.HasOne("StudentsBlazorApp.Models.classes", "_class")
                        .WithMany("students")
                        .HasForeignKey("_classId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentsBlazorApp.Models.countries", "country")
                        .WithMany("students")
                        .HasForeignKey("countryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_class");

                    b.Navigation("country");
                });

            modelBuilder.Entity("StudentsBlazorApp.Models.classes", b =>
                {
                    b.Navigation("students");
                });

            modelBuilder.Entity("StudentsBlazorApp.Models.countries", b =>
                {
                    b.Navigation("students");
                });
#pragma warning restore 612, 618
        }
    }
}
