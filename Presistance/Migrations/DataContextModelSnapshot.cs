﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Presistance;

#nullable disable

namespace Presistance.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Categories", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("30c1f7be-ed9b-4aa8-bd2f-9c5c9ac2d015"),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Mobiles"
                        },
                        new
                        {
                            Id = new Guid("1f5183f0-8fd5-45cc-9147-e32160904989"),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Watches"
                        });
                });

            modelBuilder.Entity("Domain.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoriesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CategoriesId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2cd9983d-7188-4a4f-a7bd-f6755e28fa8b"),
                            CategoryId = new Guid("e9cb6664-ef95-4c14-bfa0-1a3247f09c63"),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Iphone 13 pro max",
                            Price = 36000f
                        },
                        new
                        {
                            Id = new Guid("c5ff233a-25eb-45b7-a7d6-06ace63dd0e0"),
                            CategoryId = new Guid("e9cb6664-ef95-4c14-bfa0-1a3247f09c63"),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Samsung S22",
                            Price = 21000f
                        },
                        new
                        {
                            Id = new Guid("2afc6f18-fd99-475d-905b-9fbdf81a71d7"),
                            CategoryId = new Guid("75aa1f9f-9c21-4b82-b1bf-2499a4095a8d"),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Apple watch",
                            Price = 10000f
                        });
                });

            modelBuilder.Entity("Domain.Product", b =>
                {
                    b.HasOne("Domain.Categories", "Categories")
                        .WithMany("Products")
                        .HasForeignKey("CategoriesId");

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("Domain.Categories", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}