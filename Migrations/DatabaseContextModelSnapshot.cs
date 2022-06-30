﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentsBlazorApp.Models;

#nullable disable

namespace StudentsBlazorApp.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("StudentsBlazorApp.Models.Classes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("class_name");

                    b.HasKey("Id");

                    b.ToTable("classes");
                });

            modelBuilder.Entity("StudentsBlazorApp.Models.CountriesMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("country_name");

                    b.HasKey("Id");

                    b.ToTable("countries_master");
                });

            modelBuilder.Entity("StudentsBlazorApp.Models.Students", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT")
                        .HasColumnName("date_of_birth");

                    b.Property<int>("StudentClassId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StudentCountryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("student_name");

                    b.HasKey("Id");

                    b.HasIndex("StudentClassId");

                    b.HasIndex("StudentCountryId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("StudentsBlazorApp.Models.Students", b =>
                {
                    b.HasOne("StudentsBlazorApp.Models.Classes", "StudentClass")
                        .WithMany("studentsList")
                        .HasForeignKey("StudentClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentsBlazorApp.Models.CountriesMaster", "StudentCountry")
                        .WithMany("StudentsList")
                        .HasForeignKey("StudentCountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StudentClass");

                    b.Navigation("StudentCountry");
                });

            modelBuilder.Entity("StudentsBlazorApp.Models.Classes", b =>
                {
                    b.Navigation("studentsList");
                });

            modelBuilder.Entity("StudentsBlazorApp.Models.CountriesMaster", b =>
                {
                    b.Navigation("StudentsList");
                });
#pragma warning restore 612, 618
        }
    }
}
