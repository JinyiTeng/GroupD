﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _2DataAccessLayer.Context;

#nullable disable

namespace _2DataAccessLayer.Migrations
{
    [DbContext(typeof(DBEntitiesContext))]
    partial class DBEntitiesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_2DataAccessLayer.Context.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("_2DataAccessLayer.Context.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("_2DataAccessLayer.Context.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"), 1L, 1);

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("_2DataAccessLayer.Context.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"), 1L, 1);

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FamilyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GivenName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("PreferredName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.ToTable("People");
                });


            modelBuilder.Entity("_2DataAccessLayer.Context.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("ProductCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    modelBuilder.Entity("_2DataAccessLayer.Context.Models.ProductLoss", b =>
                        {
                            b.Property<int>("ProductLossID")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductLossID"), 1L, 1);

                            b.Property<int>("LossAmount")
                                .HasColumnType("int");


                            b.Property<string>("ProductName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");


                            b.Property<string>("ProductQuantity")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b.HasKey("ProductId");

                            b.ToTable("Products");

                            b.Property<string>("Reason")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b.HasKey("ProductLossID");

                            b.ToTable("ProductLoss");

                        });

                    modelBuilder.Entity("_2DataAccessLayer.Context.Models.Staff", b =>
                        {
                            b.Property<int>("StaffId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StaffId"), 1L, 1);

                            b.Property<string>("StaffName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b.Property<string>("StaffPhone")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b.Property<string>("StaffPosition")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b.Property<string>("StaffShift")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b.HasKey("StaffId");

                            b.ToTable("Staff");
                        });

                    modelBuilder.Entity("_2DataAccessLayer.Context.Models.Stock", b =>
                        {
                            b.Property<int>("StockID")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockID"), 1L, 1);

                            b.Property<int>("OrderAmount")
                                .HasColumnType("int");

                            b.Property<string>("ProductName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b.Property<decimal>("TotalOrderPrice")
                                .HasColumnType("decimal(18,2)");

                            b.HasKey("StockID");

                            b.ToTable("Stock");
                        });

                    modelBuilder.Entity("_2DataAccessLayer.Context.Models.Student", b =>
                        {
                            b.Property<int>("StudentId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"), 1L, 1);

                            b.Property<string>("StudentName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b.HasKey("StudentId");

                            b.ToTable("Students");
                        });

                });
            
            modelBuilder.Entity("_2DataAccessLayer.Context.Models.ProductLoss", b =>
            {
                b.Property<int>("ProductLossID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductLossID"), 1L, 1);

                b.Property<int>("LossAmount")
                    .HasColumnType("int");


                b.Property<string>("ProductName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");


                b.Property<string>("ProductQuantity")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("ProductId");

                b.ToTable("Products");

                b.Property<string>("Reason")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("ProductLossID");

                b.ToTable("ProductLoss");

            });

            modelBuilder.Entity("_2DataAccessLayer.Context.Models.Stock", b =>
            {
                b.Property<int>("StockID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockID"), 1L, 1);

                b.Property<int>("OrderAmount")
                    .HasColumnType("int");

                b.Property<string>("ProductName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<decimal>("TotalOrderPrice")
                    .HasColumnType("decimal(18,2)");

                b.HasKey("StockID");

                b.ToTable("Stock");
            });
        }
    }
}
