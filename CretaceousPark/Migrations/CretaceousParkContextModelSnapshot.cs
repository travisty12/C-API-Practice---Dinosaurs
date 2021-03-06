﻿// <auto-generated />
using CretaceousPark.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CretaceousPark.Migrations
{
    [DbContext(typeof(CretaceousParkContext))]
    partial class CretaceousParkContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CretaceousPark.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Gender");

                    b.Property<string>("Name");

                    b.Property<string>("Species");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 23,
                            Gender = "Male",
                            Name = "Derek",
                            Species = "Velociraptor"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 4,
                            Gender = "Female",
                            Name = "Sasha",
                            Species = "T Rex"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 17,
                            Gender = "Female",
                            Name = "Derek",
                            Species = "T Rex"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 65,
                            Gender = "Female",
                            Name = "Bonecrusher",
                            Species = "Chipmunk"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 9,
                            Gender = "Male",
                            Name = "Allen",
                            Species = "Triceratops"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
