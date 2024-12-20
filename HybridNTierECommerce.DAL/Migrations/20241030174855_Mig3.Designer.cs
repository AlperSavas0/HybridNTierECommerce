﻿// <auto-generated />
using System;
using HybridNTierECommerce.DAL.ContextClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HybridNTierECommerce.DAL.Migrations
{
    [DbContext(typeof(HybridECommerceContext))]
    [Migration("20241030174855_Mig3")]
    partial class Mig3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<Guid?>("ActivationCode")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "269daa65-0c75-4cd3-b942-467fa2cd262e",
                            CreatedDate = new DateTime(2024, 10, 30, 20, 48, 54, 602, DateTimeKind.Local).AddTicks(504),
                            Email = "alper@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ALPER@EMAIL.COM",
                            NormalizedUserName = "ALPER123",
                            PasswordHash = "AQAAAAIAAYagAAAAEHKTP2m2UUiDxEcpExNxycre1DZTPw3dz7I0bLM8l8LinvhbBBZo16e7u3n5rIHG1A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "86acae91-829c-4fc9-b4d8-9923afeb3536",
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "alper123"
                        });
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.AppUserProfile", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryName = "Beauty",
                            CreatedDate = new DateTime(2024, 10, 30, 20, 48, 54, 649, DateTimeKind.Local).AddTicks(9088),
                            Description = "Consequatur quae voluptatum ut et ab quam sequi vel sunt.",
                            Status = 1
                        },
                        new
                        {
                            ID = 2,
                            CategoryName = "Shoes",
                            CreatedDate = new DateTime(2024, 10, 30, 20, 48, 54, 649, DateTimeKind.Local).AddTicks(9625),
                            Description = "Tempora rerum sint ea vel ratione ducimus omnis aperiam iure.",
                            Status = 1
                        },
                        new
                        {
                            ID = 3,
                            CategoryName = "Books",
                            CreatedDate = new DateTime(2024, 10, 30, 20, 48, 54, 649, DateTimeKind.Local).AddTicks(9687),
                            Description = "İmpedit doloribus facere accusantium corrupti ea doloremque dolorem odit omnis.",
                            Status = 1
                        },
                        new
                        {
                            ID = 4,
                            CategoryName = "Jewelery",
                            CreatedDate = new DateTime(2024, 10, 30, 20, 48, 54, 649, DateTimeKind.Local).AddTicks(9746),
                            Description = "Et soluta praesentium et explicabo atque doloremque incidunt ut illum.",
                            Status = 1
                        },
                        new
                        {
                            ID = 5,
                            CategoryName = "Outdoors",
                            CreatedDate = new DateTime(2024, 10, 30, 20, 48, 54, 649, DateTimeKind.Local).AddTicks(9867),
                            Description = "İpsum quas quidem odit quis id consequatur qui id consequuntur.",
                            Status = 1
                        },
                        new
                        {
                            ID = 6,
                            CategoryName = "Beauty",
                            CreatedDate = new DateTime(2024, 10, 30, 20, 48, 54, 649, DateTimeKind.Local).AddTicks(9927),
                            Description = "Repudiandae ipsa et repellat sapiente consectetur accusamus dolores qui voluptates.",
                            Status = 1
                        },
                        new
                        {
                            ID = 7,
                            CategoryName = "Games",
                            CreatedDate = new DateTime(2024, 10, 30, 20, 48, 54, 649, DateTimeKind.Local).AddTicks(9981),
                            Description = "Aliquam officiis sit vero dolor voluptatibus amet molestias iure provident.",
                            Status = 1
                        },
                        new
                        {
                            ID = 8,
                            CategoryName = "Toys",
                            CreatedDate = new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(33),
                            Description = "Quia porro quia recusandae nostrum fugit quasi vitae eveniet molestiae.",
                            Status = 1
                        },
                        new
                        {
                            ID = 9,
                            CategoryName = "Home",
                            CreatedDate = new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(140),
                            Description = "Sunt at reiciendis a sint fugit similique repellendus quo et.",
                            Status = 1
                        },
                        new
                        {
                            ID = 10,
                            CategoryName = "Automotive",
                            CreatedDate = new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(240),
                            Description = "Tempore debitis a mollitia perferendis dolorem ipsum doloremque omnis qui.",
                            Status = 1
                        });
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("AppUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameDesctiption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AppUserID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("OrderID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UnitsInStock")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryID = 1,
                            CreatedDate = new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(451),
                            ImagePath = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22100%22%20height%3D%22100%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2250%22%20y%3D%2250%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E100x100%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Price = 404.45m,
                            ProductName = "Sleek Wooden Towels",
                            Status = 1,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 2,
                            CategoryID = 2,
                            CreatedDate = new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(972),
                            ImagePath = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22100%22%20height%3D%22100%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2250%22%20y%3D%2250%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E100x100%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Price = 951.47m,
                            ProductName = "Gorgeous Metal Tuna",
                            Status = 1,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 3,
                            CategoryID = 3,
                            CreatedDate = new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(1131),
                            ImagePath = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22100%22%20height%3D%22100%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2250%22%20y%3D%2250%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E100x100%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Price = 149.39m,
                            ProductName = "Gorgeous Soft Cheese",
                            Status = 1,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 4,
                            CategoryID = 4,
                            CreatedDate = new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(1292),
                            ImagePath = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22100%22%20height%3D%22100%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2250%22%20y%3D%2250%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E100x100%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Price = 136.83m,
                            ProductName = "Intelligent Wooden Cheese",
                            Status = 1,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 5,
                            CategoryID = 5,
                            CreatedDate = new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(1433),
                            ImagePath = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22100%22%20height%3D%22100%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2250%22%20y%3D%2250%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E100x100%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Price = 10.03m,
                            ProductName = "Intelligent Soft Pizza",
                            Status = 1,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 6,
                            CategoryID = 6,
                            CreatedDate = new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(1641),
                            ImagePath = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22100%22%20height%3D%22100%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2250%22%20y%3D%2250%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E100x100%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Price = 347.04m,
                            ProductName = "Handmade Fresh Cheese",
                            Status = 1,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 7,
                            CategoryID = 7,
                            CreatedDate = new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(1785),
                            ImagePath = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22100%22%20height%3D%22100%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2250%22%20y%3D%2250%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E100x100%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Price = 799.20m,
                            ProductName = "Gorgeous Steel Pizza",
                            Status = 1,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 8,
                            CategoryID = 8,
                            CreatedDate = new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(1973),
                            ImagePath = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22100%22%20height%3D%22100%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2250%22%20y%3D%2250%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E100x100%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Price = 255.12m,
                            ProductName = "Licensed Granite Mouse",
                            Status = 1,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 9,
                            CategoryID = 9,
                            CreatedDate = new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(2114),
                            ImagePath = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22100%22%20height%3D%22100%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2250%22%20y%3D%2250%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E100x100%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Price = 267.89m,
                            ProductName = "Intelligent Cotton Pants",
                            Status = 1,
                            UnitsInStock = 100
                        },
                        new
                        {
                            ID = 10,
                            CategoryID = 10,
                            CreatedDate = new DateTime(2024, 10, 30, 20, 48, 54, 650, DateTimeKind.Local).AddTicks(2276),
                            ImagePath = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22100%22%20height%3D%22100%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2250%22%20y%3D%2250%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E100x100%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Price = 156.60m,
                            ProductName = "Practical Wooden Chicken",
                            Status = 1,
                            UnitsInStock = 100
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "91081929-9164-4a8e-ac84-93398788b00b",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "567c5b73-d9df-40c6-9f72-214332240501",
                            Name = "Member",
                            NormalizedName = "MEMBER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.AppUserProfile", b =>
                {
                    b.HasOne("HybridNTierECommerce.ENTITIES.Models.AppUser", "AppUser")
                        .WithOne("Profile")
                        .HasForeignKey("HybridNTierECommerce.ENTITIES.Models.AppUserProfile", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.Order", b =>
                {
                    b.HasOne("HybridNTierECommerce.ENTITIES.Models.AppUser", "AppUser")
                        .WithMany("Orders")
                        .HasForeignKey("AppUserID");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.OrderDetail", b =>
                {
                    b.HasOne("HybridNTierECommerce.ENTITIES.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HybridNTierECommerce.ENTITIES.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.Product", b =>
                {
                    b.HasOne("HybridNTierECommerce.ENTITIES.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("HybridNTierECommerce.ENTITIES.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("HybridNTierECommerce.ENTITIES.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HybridNTierECommerce.ENTITIES.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("HybridNTierECommerce.ENTITIES.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.AppUser", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Profile")
                        .IsRequired();
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("HybridNTierECommerce.ENTITIES.Models.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
