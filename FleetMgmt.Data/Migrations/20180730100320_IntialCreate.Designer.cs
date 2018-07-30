﻿// <auto-generated />
using System;
using FleetMgmt.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FleetMgmt.Data.Migrations
{
    [DbContext(typeof(FmDbContext))]
    [Migration("20180730100320_IntialCreate")]
    partial class IntialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FleetMgmt.Data.Entities.Driver", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LicenseNumber")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("FleetMgmt.Data.Entities.Vehicle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ChassisNumber");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("EngineNumber");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("PlateNumber")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
