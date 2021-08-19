﻿// <auto-generated />
using System;
using Garage2._0.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Garage2._0.Migrations
{
    [DbContext(typeof(Garage2_0Context))]
    [Migration("20210819145045_changedFieldVehicleType")]
    partial class changedFieldVehicleType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Garage2._0.Models.Entities.ParkedVehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmountOfWheels")
                        .HasColumnType("int");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ParkedVehicle");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AmountOfWheels = 4,
                            ArrivalTime = new DateTime(2021, 8, 19, 16, 50, 45, 69, DateTimeKind.Local).AddTicks(2632),
                            Color = "Red",
                            Make = "BMW",
                            Model = "C5",
                            RegNo = "ABC123",
                            VehicleType = 0
                        },
                        new
                        {
                            Id = 2,
                            AmountOfWheels = 4,
                            ArrivalTime = new DateTime(2021, 8, 19, 16, 50, 45, 73, DateTimeKind.Local).AddTicks(7775),
                            Color = "White",
                            Make = "Volvo",
                            Model = "Z7",
                            RegNo = "EFG124",
                            VehicleType = 0
                        },
                        new
                        {
                            Id = 3,
                            AmountOfWheels = 4,
                            ArrivalTime = new DateTime(2021, 8, 19, 16, 50, 45, 73, DateTimeKind.Local).AddTicks(7821),
                            Color = "Black",
                            Make = "Audi",
                            Model = "M09",
                            RegNo = "GHY125",
                            VehicleType = 0
                        },
                        new
                        {
                            Id = 4,
                            AmountOfWheels = 4,
                            ArrivalTime = new DateTime(2021, 8, 19, 16, 50, 45, 73, DateTimeKind.Local).AddTicks(7827),
                            Color = "Red",
                            Make = "BMW",
                            Model = "FF5",
                            RegNo = "LKJ126",
                            VehicleType = 0
                        },
                        new
                        {
                            Id = 5,
                            AmountOfWheels = 12,
                            ArrivalTime = new DateTime(2021, 8, 19, 16, 50, 45, 73, DateTimeKind.Local).AddTicks(7832),
                            Color = "Yellow",
                            Make = "BMW",
                            Model = "C95",
                            RegNo = "OPR127",
                            VehicleType = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
