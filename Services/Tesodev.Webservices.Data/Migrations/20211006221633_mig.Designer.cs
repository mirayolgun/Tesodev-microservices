﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tesodev.Webservices.Data.Concrete.Contexts;

namespace Tesodev.Webservices.Data.Migrations
{
    [DbContext(typeof(TesodevdbContext))]
    [Migration("20211006221633_mig")]
    partial class mig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Infrastructure.Entities.Addess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrderId");

                    b.ToTable("Addesses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressLine = "Ayaş Ankara Yolu Blv. No:93, 06796 ",
                            City = "Ankara",
                            CityCode = "312",
                            Country = "Türkiye",
                            CreatedDate = new DateTime(2021, 10, 7, 1, 16, 32, 890, DateTimeKind.Local).AddTicks(7254),
                            CustomerId = 1,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 2,
                            AddressLine = "123 Main Street Room 22",
                            City = "New York",
                            CityCode = "212",
                            Country = "ABD",
                            CreatedDate = new DateTime(2021, 10, 7, 1, 16, 32, 890, DateTimeKind.Local).AddTicks(9083),
                            CustomerId = 2,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 3,
                            AddressLine = "221B Baker Street",
                            City = "Londra",
                            CityCode = "212",
                            Country = "İngiltere",
                            CreatedDate = new DateTime(2021, 10, 7, 1, 16, 32, 890, DateTimeKind.Local).AddTicks(9155),
                            CustomerId = 3,
                            OrderId = 1
                        });
                });

            modelBuilder.Entity("API.Infrastructure.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2021, 10, 7, 1, 16, 32, 890, DateTimeKind.Local).AddTicks(9638),
                            Email = "mehmethatay@gmail.com",
                            Name = "Mehmet Hatay"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2021, 10, 7, 1, 16, 32, 891, DateTimeKind.Local).AddTicks(309),
                            Email = "doganbulut@gmail.com",
                            Name = "Doğan Bulut"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2021, 10, 7, 1, 16, 32, 891, DateTimeKind.Local).AddTicks(337),
                            Email = "unastubbs@hotmail.com",
                            Name = "Una Stubbs"
                        });
                });

            modelBuilder.Entity("API.Infrastructure.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2021, 10, 7, 1, 16, 32, 891, DateTimeKind.Local).AddTicks(780),
                            CustomerId = 3,
                            Price = 80,
                            Quantity = 2,
                            Status = "kargoya verildi"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2021, 10, 7, 1, 16, 32, 891, DateTimeKind.Local).AddTicks(1815),
                            CustomerId = 2,
                            Price = 100,
                            Quantity = 1,
                            Status = "İptal edildi"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2021, 10, 7, 1, 16, 32, 891, DateTimeKind.Local).AddTicks(1872),
                            CustomerId = 1,
                            Price = 150,
                            Quantity = 4,
                            Status = "Teslim edildi"
                        });
                });

            modelBuilder.Entity("API.Infrastructure.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2021, 10, 7, 1, 16, 32, 888, DateTimeKind.Local).AddTicks(8165),
                            ImageUrl = "tasarimcicek.jpg",
                            Name = "Pembe incili Kutuda Renkli Lisyantus",
                            OrderId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2021, 10, 7, 1, 16, 32, 889, DateTimeKind.Local).AddTicks(6783),
                            ImageUrl = "dogumgunucicekleri.jpg",
                            Name = "Mutluluk Kutusu",
                            OrderId = 3
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2021, 10, 7, 1, 16, 32, 889, DateTimeKind.Local).AddTicks(6830),
                            ImageUrl = "cicekbuketleri.jpg",
                            Name = "Pembe Papatyalı Çiçek Buketi",
                            OrderId = 2
                        });
                });

            modelBuilder.Entity("API.Infrastructure.Entities.Addess", b =>
                {
                    b.HasOne("API.Infrastructure.Entities.Customer", "Customer")
                        .WithMany("Addesses")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Infrastructure.Entities.Order", "Order")
                        .WithMany("Addesses")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Infrastructure.Entities.Order", b =>
                {
                    b.HasOne("API.Infrastructure.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Infrastructure.Entities.Product", b =>
                {
                    b.HasOne("API.Infrastructure.Entities.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}