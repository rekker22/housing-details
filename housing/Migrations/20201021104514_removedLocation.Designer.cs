﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using housing.Models;

namespace housing.Migrations
{
    [DbContext(typeof(dataContext))]
    [Migration("20201021104514_removedLocation")]
    partial class removedLocation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("housing.Models.Accommodation", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypePreferenceOrder1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypePreferenceOrder2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypePreferenceOrder3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypePreferenceOrder4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dataLocation")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("dataLocation");

                    b.ToTable("Accds");
                });

            modelBuilder.Entity("housing.Models.PlacestoVisit", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypePreferenceOrder1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypePreferenceOrder2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypePreferenceOrder3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypePreferenceOrder4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dataLocation")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("dataLocation");

                    b.ToTable("Ptvs");
                });

            modelBuilder.Entity("housing.Models.data", b =>
                {
                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Budget")
                        .HasColumnType("int");

                    b.Property<int>("Dfd")
                        .HasColumnType("int");

                    b.HasKey("Location");

                    b.ToTable("Datas");
                });

            modelBuilder.Entity("housing.Models.Accommodation", b =>
                {
                    b.HasOne("housing.Models.data", null)
                        .WithMany("accd")
                        .HasForeignKey("dataLocation");
                });

            modelBuilder.Entity("housing.Models.PlacestoVisit", b =>
                {
                    b.HasOne("housing.Models.data", null)
                        .WithMany("ptv")
                        .HasForeignKey("dataLocation");
                });
#pragma warning restore 612, 618
        }
    }
}