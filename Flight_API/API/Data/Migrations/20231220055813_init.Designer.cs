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
    [Migration("20231220055813_init")]
    partial class init
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
                    b.Property<string>("FlightNo")
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("Current_Pass")
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

                    b.HasKey("FlightNo");

                    b.ToTable("Flights");

                    b.HasData(
                        new
                        {
                            FlightNo = "AYE35",
                            Capacity = 150,
                            CurrentPass = 0,
                            Destination = "TSA",
                            Gate = "",
                            Origin = "DUL",
                            TimeDes = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeOri = new DateTime(2023, 12, 20, 0, 58, 13, 14, DateTimeKind.Local).AddTicks(5320)
                        },
                        new
                        {
                            FlightNo = "EYA23",
                            Capacity = 180,
                            CurrentPass = 0,
                            Destination = "DUL",
                            Gate = "",
                            Origin = "TSA",
                            TimeDes = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeOri = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("API.Models.PassengerFlight_Booking", b =>
                {
                    b.Property<string>("FlightNo")
                        .HasColumnType("varchar(5)");

                    b.Property<int>("PassengerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("BookingTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Seat")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Seat");

                    b.HasKey("FlightNo", "PassengerID");

                    b.HasIndex("PassengerID");

                    b.ToTable("PassengerFlightMappings");
                });

            modelBuilder.Entity("API.Models.PassengerObject", b =>
                {
                    b.Property<int>("Passenger_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("varchar(24)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("varchar(24)");

                    b.HasKey("Passenger_ID");

                    b.ToTable("Passengers");

                    b.HasData(
                        new
                        {
                            PassengerID = 1,
                            Email = "abc@gmail.com",
                            FirstName = "Bach",
                            LastName = "Duong"
                        },
                        new
                        {
                            PassengerID = 2,
                            Email = "cba@gmail.com",
                            FirstName = "Nhi",
                            LastName = "Mai"
                        });
                });

            modelBuilder.Entity("API.Models.PassengerFlight_Booking", b =>
                {
                    b.HasOne("API.Models.FlightObject", "Flight")
                        .WithMany("PassengerFlightMapper")
                        .HasForeignKey("FlightNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Models.PassengerObject", "Passenger")
                        .WithMany("PassengerFlightMapper")
                        .HasForeignKey("PassengerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");

                    b.Navigation("Passenger");
                });

            modelBuilder.Entity("API.Models.FlightObject", b =>
                {
                    b.Navigation("PassengerFlightMapper");
                });

            modelBuilder.Entity("API.Models.PassengerObject", b =>
                {
                    b.Navigation("PassengerFlightMapper");
                });
#pragma warning restore 612, 618
        }
    }
}
