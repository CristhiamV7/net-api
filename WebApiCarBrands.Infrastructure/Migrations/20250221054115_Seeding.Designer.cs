﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApiCarBrands.Infrastructure.Data;

#nullable disable

namespace WebApiCarBrands.Infrastructure.Migrations
{
    [DbContext(typeof(CarBrandDbContext))]
    [Migration("20250221054115_Seeding")]
    partial class Seeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebApiCarBrands.Domain.Entities.CarBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Year")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CarBrands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "Japan",
                            Description = "A reliable and popular car brand",
                            Name = "Toyota",
                            Year = "1937"
                        },
                        new
                        {
                            Id = 2,
                            Country = "Germany",
                            Description = "A luxury car brand with elegant designs",
                            Name = "Mercedes-Benz",
                            Year = "1926"
                        },
                        new
                        {
                            Id = 3,
                            Country = "USA",
                            Description = "An innovative car brand known for the Model T",
                            Name = "Ford",
                            Year = "1903"
                        },
                        new
                        {
                            Id = 4,
                            Country = "Italy",
                            Description = "A sports car brand known for its speed and performance",
                            Name = "Ferrari",
                            Year = "1939"
                        },
                        new
                        {
                            Id = 5,
                            Country = "USA",
                            Description = "An electric car brand with cutting-edge technology",
                            Name = "Tesla",
                            Year = "2003"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
