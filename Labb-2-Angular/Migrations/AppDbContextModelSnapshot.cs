﻿// <auto-generated />
using Labb_2_Angular.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb_2_Angular.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Labb_2_Angular.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DepartmentName = "Sale"
                        },
                        new
                        {
                            DepartmentId = 2,
                            DepartmentName = "Development"
                        },
                        new
                        {
                            DepartmentId = 3,
                            DepartmentName = "Hr"
                        });
                });

            modelBuilder.Entity("Labb_2_Angular.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<bool>("Admin")
                        .HasColumnType("bit");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MonthSalary")
                        .HasColumnType("float");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Admin = false,
                            Adress = "Kungsgatan 1",
                            DepartmentId = 2,
                            Email = "erik@norell.com",
                            FirstName = "Erik",
                            Gender = "Male",
                            LastName = "Norell",
                            MonthSalary = 50000.0,
                            PhoneNumber = "0701232343",
                            Title = "Developer"
                        },
                        new
                        {
                            EmployeeId = 2,
                            Admin = false,
                            Adress = "Sveagatan 3",
                            DepartmentId = 1,
                            Email = "lukas@rose.com",
                            FirstName = "Lukas",
                            Gender = "Male",
                            LastName = "Rose",
                            MonthSalary = 45000.0,
                            PhoneNumber = "0709878761",
                            Title = "Sales Manager"
                        },
                        new
                        {
                            EmployeeId = 3,
                            Admin = true,
                            Adress = "Drottninggatan 4",
                            DepartmentId = 2,
                            Email = "tobias@landen.com",
                            FirstName = "Tobias",
                            Gender = "Male",
                            LastName = "Landen",
                            MonthSalary = 60000.0,
                            PhoneNumber = "0705362188",
                            Title = "Team Leader"
                        });
                });

            modelBuilder.Entity("Labb_2_Angular.Models.Employee", b =>
                {
                    b.HasOne("Labb_2_Angular.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
