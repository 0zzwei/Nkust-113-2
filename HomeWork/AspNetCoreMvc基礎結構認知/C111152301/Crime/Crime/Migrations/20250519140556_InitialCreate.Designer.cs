﻿// <auto-generated />
using Crime.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Crime.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250519140556_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.5");

            modelBuilder.Entity("CrimeStat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CrimeRate")
                        .HasColumnType("REAL");

                    b.Property<double>("IncidentRate")
                        .HasColumnType("REAL");

                    b.Property<int>("Month")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OtherCases")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RapeCases")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RobberyCases")
                        .HasColumnType("INTEGER");

                    b.Property<double>("SolveRate")
                        .HasColumnType("REAL");

                    b.Property<int>("SolvedBacklog")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SolvedCurrent")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SolvedOther")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SolvedTotal")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Suspects")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TotalCases")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("CrimeStats");
                });

            modelBuilder.Entity("UserAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
