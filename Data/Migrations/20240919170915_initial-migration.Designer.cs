﻿// <auto-generated />
using System;
using Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(BookStoreDbContext))]
    [Migration("20240919170915_initial-migration")]
    partial class initialmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Data.Books.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasPrecision(18, 3)
                        .HasColumnType("decimal(18,3)");

                    b.Property<DateTime?>("PublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "George Orwell",
                            Price = 10m,
                            PublicationDate = new DateTime(2024, 9, 19, 20, 9, 15, 525, DateTimeKind.Local).AddTicks(2700),
                            Title = "Epic Reads Book Club"
                        },
                        new
                        {
                            Id = 2,
                            Author = "John Green",
                            Price = 10m,
                            PublicationDate = new DateTime(2024, 9, 19, 20, 9, 15, 525, DateTimeKind.Local).AddTicks(2715),
                            Title = "A Sarah Dessen"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Melissa Pearl",
                            Price = 10m,
                            PublicationDate = new DateTime(2024, 9, 19, 20, 9, 15, 525, DateTimeKind.Local).AddTicks(2716),
                            Title = "Must-Read Teen Novel"
                        },
                        new
                        {
                            Id = 4,
                            Author = " Jeramey Kraatz",
                            Price = 10m,
                            PublicationDate = new DateTime(2024, 9, 19, 20, 9, 15, 525, DateTimeKind.Local).AddTicks(2717),
                            Title = "Hunger for Dystopian"
                        },
                        new
                        {
                            Id = 5,
                            Author = "John Green",
                            Price = 10m,
                            PublicationDate = new DateTime(2024, 9, 19, 20, 9, 15, 525, DateTimeKind.Local).AddTicks(2719),
                            Title = "The John Green"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
