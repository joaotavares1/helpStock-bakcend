﻿// <auto-generated />
using HelpStockApp.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HelpStockApp.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HelpStockApp.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Material Escolar"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Eletrônicos"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Acessórios"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Móveis"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Vestuário"
                        });
                });

            modelBuilder.Entity("HelpStockApp.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 0,
                            Description = "PencilCase",
                            Image = "image1",
                            Name = "Estojo",
                            Price = 20m,
                            Stock = 30
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 0,
                            Description = "Samsung",
                            Image = "image1",
                            Name = "Celular",
                            Price = 1500m,
                            Stock = 50
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 0,
                            Description = "Argola grande",
                            Image = "image1",
                            Name = "Brinco",
                            Price = 300m,
                            Stock = 10
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 0,
                            Description = "Gamer",
                            Image = "image1",
                            Name = "Cadeira",
                            Price = 2000m,
                            Stock = 20
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 0,
                            Description = "Masculina",
                            Image = "image1",
                            Name = "Camisa",
                            Price = 250m,
                            Stock = 5
                        });
                });

            modelBuilder.Entity("HelpStockApp.Domain.Entities.Product", b =>
                {
                    b.HasOne("HelpStockApp.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("HelpStockApp.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
