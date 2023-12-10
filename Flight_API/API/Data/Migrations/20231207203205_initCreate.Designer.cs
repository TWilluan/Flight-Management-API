﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(APIdbContext))]
    [Migration("20231207203205_initCreate")]
    partial class initCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("API.Models.FlightObject", b =>
                {
                    b.Property<string>("Flight_No")
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.Property<string>("Gate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.Property<DateTime>("Time_Des")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Time_Ori")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Flight_No");

                    b.ToTable("Flights");

                    b.HasData(
                        new
                        {
                            FlightNo = "AYE35",
                            Capacity = 150,
                            Destination = "TSA",
                            Gate = "",
                            Origin = "DUL",
                            TimeDes = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeOri = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            FlightNo = "EYA23",
                            Capacity = 180,
                            Destination = "DUL",
                            Gate = "",
                            Origin = "TSA",
                            TimeDes = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeOri = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("API.Models.PassengerObject", b =>
                {
                    b.Property<Guid>("Passenger_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("varchar(24)");

                    b.Property<string>("Flight_No")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("varchar(24)");

                    b.Property<string>("Seat")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Passenger_ID");

                    b.ToTable("Passengers");

                    b.HasData(
                        new
                        {
                            PassengerID = new Guid("f92c112a-30f0-4164-8128-d7de7e38a304"),
                            Email = "abc@gmail.com",
                            FirstName = "Tuan",
                            FlightNo = "AYE35",
                            LastName = "Vo",
                            Seat = ""
                        },
                        new
                        {
                            PassengerID = new Guid("d118bc6e-d5fc-4baf-8632-cc3763dca1a6"),
                            Email = "cba@gmail.com",
                            FirstName = "Chi",
                            FlightNo = "EYA23",
                            LastName = "Le",
                            Seat = ""
                        });
                });
#pragma warning restore 612, 618
        }
    }
}