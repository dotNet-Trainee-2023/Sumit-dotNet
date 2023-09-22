﻿// <auto-generated />
using MVCApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCApplication.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230922042614_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("MVCApplication.Models.Employee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Salary")
                        .HasColumnType("REAL");

                    b.HasKey("id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Department = "Web Development",
                            Name = "Ram",
                            Position = "Front-end Developer",
                            Salary = 30000.0
                        },
                        new
                        {
                            id = 2,
                            Department = "HR",
                            Name = "Sudarshan",
                            Position = "Manager",
                            Salary = 40000.0
                        },
                        new
                        {
                            id = 3,
                            Department = "Web Development",
                            Name = "Manoj",
                            Position = "Back-end Developer",
                            Salary = 35000.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
