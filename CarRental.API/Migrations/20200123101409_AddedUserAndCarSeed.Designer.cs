﻿// <auto-generated />
using System;
using CarRental.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarRental.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200123101409_AddedUserAndCarSeed")]
    partial class AddedUserAndCarSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("CarRental.API.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AverageConsumption")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Color")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fuel")
                        .HasColumnType("TEXT");

                    b.Property<string>("LicensePlateNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfPassengers")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarRental.API.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CarId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsMain")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("CarRental.API.Models.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CarsId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UsersId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CarsId");

                    b.HasIndex("UsersId");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("CarRental.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CarRental.API.Models.Photo", b =>
                {
                    b.HasOne("CarRental.API.Models.Car", "Car")
                        .WithMany("Photos")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarRental.API.Models.Rental", b =>
                {
                    b.HasOne("CarRental.API.Models.Car", "Cars")
                        .WithMany()
                        .HasForeignKey("CarsId");

                    b.HasOne("CarRental.API.Models.User", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId");
                });
#pragma warning restore 612, 618
        }
    }
}