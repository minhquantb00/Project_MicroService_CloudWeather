﻿// <auto-generated />
using System;
using CloudWeather.Report.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CloudWeather.Report.Migrations
{
    [DbContext(typeof(ReportDbContext))]
    [Migration("20231130100947_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CloudWeather.Report.Entities.WeatherReport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("AverageHighF")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AverageLowF")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("RainfallTotalInches")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SnowTotalInches")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("weatherReport", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}