﻿// <auto-generated />
using System;
using Brady_N_PayRoll_Application.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Brady_N_PayRoll_Application.Migrations
{
    [DbContext(typeof(Brady_N_PayRoll_ApplicationContext))]
    partial class Brady_N_PayRoll_ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Brady_N_PayRoll_Application.Models.Employee", b =>
                {
                    b.Property<int?>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("EmployeeID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("hourlyRate")
                        .HasColumnType("int");

                    b.Property<int?>("hours")
                        .HasColumnType("int");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("postionId")
                        .HasColumnType("int");

                    b.Property<int?>("salary")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.HasIndex("postionId");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            EmployeeID = 10,
                            Address = "550 East Spring st",
                            email = "JohnDoe123@gmail.com",
                            firstName = "John",
                            hourlyRate = 15,
                            lastName = "Doe",
                            phone = "123-456-7890",
                            postionId = 1
                        });
                });

            modelBuilder.Entity("Brady_N_PayRoll_Application.Models.position", b =>
                {
                    b.Property<int>("positionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("positionId"), 1L, 1);

                    b.Property<string>("positionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("positionId");

                    b.ToTable("position");

                    b.HasData(
                        new
                        {
                            positionId = 1,
                            positionName = "Team Lead"
                        },
                        new
                        {
                            positionId = 2,
                            positionName = "Team member"
                        },
                        new
                        {
                            positionId = 3,
                            positionName = "Manager"
                        });
                });

            modelBuilder.Entity("Brady_N_PayRoll_Application.Models.Employee", b =>
                {
                    b.HasOne("Brady_N_PayRoll_Application.Models.position", "position")
                        .WithMany()
                        .HasForeignKey("postionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("position");
                });
#pragma warning restore 612, 618
        }
    }
}
