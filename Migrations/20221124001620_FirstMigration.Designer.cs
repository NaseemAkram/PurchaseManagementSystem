﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PurchaseManagementSystem.DataContext;

#nullable disable

namespace PurchaseManagementSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221124001620_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PurchaseManagementSystem.Models.Employee", b =>
                {
                    b.Property<int>("Emp_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Emp_Id"), 1L, 1);

                    b.Property<string>("Emp_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Emp_Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("PurchaseManagementSystem.Models.Issuance", b =>
                {
                    b.Property<int>("Issue_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Issue_Id"), 1L, 1);

                    b.Property<string>("Employee_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Issue_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Issue_Id");

                    b.ToTable("Issuance");
                });

            modelBuilder.Entity("PurchaseManagementSystem.Models.Item", b =>
                {
                    b.Property<int>("Item_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Item_Id"), 1L, 1);

                    b.Property<string>("Item_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Item_Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Item_Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("PurchaseManagementSystem.Models.Purchase", b =>
                {
                    b.Property<int>("Purchase_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Purchase_Id"), 1L, 1);

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("Purchase_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Purchase_Item")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Purchase_Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Vendor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Purchase_Id");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("PurchaseManagementSystem.Models.Vendor", b =>
                {
                    b.Property<int>("Vendor_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Vendor_Id"), 1L, 1);

                    b.Property<string>("Vendor_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Vendor_Id");

                    b.ToTable("Vendors");
                });
#pragma warning restore 612, 618
        }
    }
}
