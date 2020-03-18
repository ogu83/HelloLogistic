﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using helloLogistic.Models;

namespace helloLogistic.Migrations
{
    [DbContext(typeof(ShippingContext))]
    partial class ShippingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("helloLogistic.Models.Box", b =>
                {
                    b.Property<int>("BoxId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PartCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("BoxId");

                    b.ToTable("Boxes");
                });

            modelBuilder.Entity("helloLogistic.Models.Part", b =>
                {
                    b.Property<int>("PartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BoxId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PartCost")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PartWeight")
                        .HasColumnType("INTEGER");

                    b.HasKey("PartId");

                    b.ToTable("Parts");
                });
#pragma warning restore 612, 618
        }
    }
}
