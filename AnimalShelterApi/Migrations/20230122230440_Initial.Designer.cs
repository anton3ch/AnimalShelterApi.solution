﻿// <auto-generated />
using AnimalShelterAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CretaceousApi.Migrations
{
    [DbContext(typeof(AnimalShelterAPIContext))]
    [Migration("20230122230440_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelterAPI.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 7,
                            Breed = "Golden Retriever",
                            Name = "Jack"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 10,
                            Breed = "Mix",
                            Name = "Rex"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 2,
                            Breed = "Sphinx",
                            Name = "Zoe"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 4,
                            Breed = "Doberman",
                            Name = "Maui"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
