﻿// <auto-generated />
using System;
using Cargo_Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cargo_Database.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231111101248_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cargo_Database.Entitys.CargoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CisternId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductVolym")
                        .HasColumnType("int");

                    b.Property<int>("VesselId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CisternId");

                    b.HasIndex("VesselId");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("Cargo_Database.Entitys.CisternEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CisternName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxUllage")
                        .HasColumnType("int");

                    b.Property<int>("MaxVolym")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cistern");
                });

            modelBuilder.Entity("Cargo_Database.Entitys.CisternMeasureEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CisternId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Ullage")
                        .HasColumnType("int");

                    b.Property<int>("Volym")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CisternId");

                    b.ToTable("CisternMeasure");
                });

            modelBuilder.Entity("Cargo_Database.Entitys.VesselEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("HarbourName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VesselName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vessel");
                });

            modelBuilder.Entity("Cargo_Database.Entitys.CargoEntity", b =>
                {
                    b.HasOne("Cargo_Database.Entitys.CisternEntity", "Cistern")
                        .WithMany()
                        .HasForeignKey("CisternId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cargo_Database.Entitys.VesselEntity", "Vessel")
                        .WithMany()
                        .HasForeignKey("VesselId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cistern");

                    b.Navigation("Vessel");
                });

            modelBuilder.Entity("Cargo_Database.Entitys.CisternMeasureEntity", b =>
                {
                    b.HasOne("Cargo_Database.Entitys.CisternEntity", "Cistern")
                        .WithMany()
                        .HasForeignKey("CisternId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cistern");
                });
#pragma warning restore 612, 618
        }
    }
}
