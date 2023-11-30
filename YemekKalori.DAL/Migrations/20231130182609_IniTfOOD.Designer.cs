﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YemekKalori.DAL.Context;

#nullable disable

namespace YemekKalori.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231130182609_IniTfOOD")]
    partial class IniTfOOD
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("YemekKalori.Domain.Entities.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Calorie")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CarbRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FatRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProteinRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Foods", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Calorie = 155m,
                            CarbRate = 1.1m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(852),
                            FatRate = 10.6m,
                            Name = "Haşlanmış Yumurta",
                            ProteinRate = 12.6m,
                            Status = 0,
                            Type = 5
                        },
                        new
                        {
                            Id = 2,
                            Calorie = 264m,
                            CarbRate = 1.4m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(857),
                            FatRate = 21m,
                            Name = "Peynir",
                            ProteinRate = 18m,
                            Status = 0,
                            Type = 4
                        },
                        new
                        {
                            Id = 3,
                            Calorie = 115m,
                            CarbRate = 6m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(859),
                            FatRate = 11m,
                            Name = "Siyah Zeytin",
                            ProteinRate = 0.8m,
                            Status = 0,
                            Type = 2
                        },
                        new
                        {
                            Id = 4,
                            Calorie = 145m,
                            CarbRate = 3.8m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(860),
                            FatRate = 15.3m,
                            Name = "Yeşil Zeytin",
                            ProteinRate = 1m,
                            Status = 0,
                            Type = 2
                        },
                        new
                        {
                            Id = 5,
                            Calorie = 196m,
                            CarbRate = 1.1m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(863),
                            FatRate = 15m,
                            Name = "Sahanda Yumurta",
                            ProteinRate = 14m,
                            Status = 0,
                            Type = 5
                        },
                        new
                        {
                            Id = 6,
                            Calorie = 106m,
                            CarbRate = 10m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(864),
                            FatRate = 4.9m,
                            Name = "Menemen",
                            ProteinRate = 6.4m,
                            Status = 0,
                            Type = 5
                        },
                        new
                        {
                            Id = 7,
                            Calorie = 266m,
                            CarbRate = 67m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(865),
                            FatRate = 0.2m,
                            Name = "Reçel",
                            ProteinRate = 0.3m,
                            Status = 0,
                            Type = 1
                        },
                        new
                        {
                            Id = 8,
                            Calorie = 304m,
                            CarbRate = 82m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(867),
                            FatRate = 0m,
                            Name = "Bal",
                            ProteinRate = 0.3m,
                            Status = 0,
                            Type = 8
                        },
                        new
                        {
                            Id = 9,
                            Calorie = 336m,
                            CarbRate = 1.4m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(868),
                            FatRate = 30m,
                            Name = "Salam",
                            ProteinRate = 13m,
                            Status = 0,
                            Type = 3
                        },
                        new
                        {
                            Id = 10,
                            Calorie = 1m,
                            CarbRate = 0.3m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(869),
                            FatRate = 0m,
                            Name = "Çay",
                            ProteinRate = 0m,
                            Status = 0,
                            Type = 9
                        },
                        new
                        {
                            Id = 11,
                            Calorie = 1m,
                            CarbRate = 0m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(871),
                            FatRate = 0m,
                            Name = "Yeşil Çay",
                            ProteinRate = 0m,
                            Status = 0,
                            Type = 9
                        },
                        new
                        {
                            Id = 12,
                            Calorie = 45m,
                            CarbRate = 10.4m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(872),
                            FatRate = 0.2m,
                            Name = "Portakal Suyu",
                            ProteinRate = 0.7m,
                            Status = 0,
                            Type = 10
                        },
                        new
                        {
                            Id = 13,
                            Calorie = 42m,
                            CarbRate = 5m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(873),
                            FatRate = 1m,
                            Name = "Süt",
                            ProteinRate = 3.4m,
                            Status = 0,
                            Type = 4
                        },
                        new
                        {
                            Id = 14,
                            Calorie = 66m,
                            CarbRate = 9.2m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(874),
                            FatRate = 2.2m,
                            Name = "Mercimek Çorbası",
                            ProteinRate = 4.1m,
                            Status = 0,
                            Type = 2
                        },
                        new
                        {
                            Id = 15,
                            Calorie = 39m,
                            CarbRate = 3.9m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(877),
                            FatRate = 1.5m,
                            Name = "Tavuk Çorbası",
                            ProteinRate = 2.9m,
                            Status = 0,
                            Type = 3
                        },
                        new
                        {
                            Id = 16,
                            Calorie = 32m,
                            CarbRate = 4.3m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(878),
                            FatRate = 1.6m,
                            Name = "Domates Çorbası",
                            ProteinRate = 1.2m,
                            Status = 0,
                            Type = 2
                        },
                        new
                        {
                            Id = 17,
                            Calorie = 40m,
                            CarbRate = 5.3m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(879),
                            FatRate = 1.5m,
                            Name = "Sebze Çorbası",
                            ProteinRate = 1.4m,
                            Status = 0,
                            Type = 2
                        },
                        new
                        {
                            Id = 18,
                            Calorie = 130m,
                            CarbRate = 28.2m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(881),
                            FatRate = 0.3m,
                            Name = "Pirinç Pilavı",
                            ProteinRate = 2.7m,
                            Status = 0,
                            Type = 6
                        },
                        new
                        {
                            Id = 19,
                            Calorie = 83m,
                            CarbRate = 18.6m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(882),
                            FatRate = 0.2m,
                            Name = "Bulgur Pilavı",
                            ProteinRate = 3.1m,
                            Status = 0,
                            Type = 6
                        },
                        new
                        {
                            Id = 20,
                            Calorie = 131m,
                            CarbRate = 25m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(883),
                            FatRate = 1.1m,
                            Name = "Makarna",
                            ProteinRate = 5m,
                            Status = 0,
                            Type = 7
                        },
                        new
                        {
                            Id = 21,
                            Calorie = 180m,
                            CarbRate = 2m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(885),
                            FatRate = 8m,
                            Name = "Kebap",
                            ProteinRate = 25m,
                            Status = 0,
                            Type = 3
                        },
                        new
                        {
                            Id = 22,
                            Calorie = 225m,
                            CarbRate = 2.2m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(886),
                            FatRate = 12m,
                            Name = "Döner",
                            ProteinRate = 26m,
                            Status = 0,
                            Type = 3
                        },
                        new
                        {
                            Id = 23,
                            Calorie = 333m,
                            CarbRate = 31.8m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(888),
                            FatRate = 17.8m,
                            Name = "Falafel",
                            ProteinRate = 13.3m,
                            Status = 0,
                            Type = 2
                        },
                        new
                        {
                            Id = 24,
                            Calorie = 254m,
                            CarbRate = 30m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(889),
                            FatRate = 10m,
                            Name = "Hamburger",
                            ProteinRate = 12m,
                            Status = 0,
                            Type = 3
                        },
                        new
                        {
                            Id = 25,
                            Calorie = 20m,
                            CarbRate = 4m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(891),
                            FatRate = 0.2m,
                            Name = "Mevsim Salata",
                            ProteinRate = 1m,
                            Status = 0,
                            Type = 2
                        },
                        new
                        {
                            Id = 26,
                            Calorie = 23m,
                            CarbRate = 4.3m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(892),
                            FatRate = 0.4m,
                            Name = "Çoban Salata",
                            ProteinRate = 1.1m,
                            Status = 0,
                            Type = 2
                        },
                        new
                        {
                            Id = 27,
                            Calorie = 265m,
                            CarbRate = 49m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(893),
                            FatRate = 3.2m,
                            Name = "Beyaz Ekmek",
                            ProteinRate = 9m,
                            Status = 0,
                            Type = 7
                        },
                        new
                        {
                            Id = 28,
                            Calorie = 247m,
                            CarbRate = 41m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(895),
                            FatRate = 4.2m,
                            Name = "Keepekli Ekmek",
                            ProteinRate = 13m,
                            Status = 0,
                            Type = 7
                        },
                        new
                        {
                            Id = 29,
                            Calorie = 259m,
                            CarbRate = 48.3m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(896),
                            FatRate = 3.3m,
                            Name = "Çavdar Ekmeği",
                            ProteinRate = 8.5m,
                            Status = 0,
                            Type = 7
                        },
                        new
                        {
                            Id = 30,
                            Calorie = 247m,
                            CarbRate = 43.4m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(897),
                            FatRate = 4.4m,
                            Name = "Tam Tahıllı Ekmek",
                            ProteinRate = 13m,
                            Status = 0,
                            Type = 7
                        },
                        new
                        {
                            Id = 31,
                            Calorie = 0.5m,
                            CarbRate = 0m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(900),
                            FatRate = 0m,
                            Name = "Light Cola",
                            ProteinRate = 0m,
                            Status = 0,
                            Type = 11
                        },
                        new
                        {
                            Id = 32,
                            Calorie = 48m,
                            CarbRate = 12m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(902),
                            FatRate = 0m,
                            Name = "Fanta",
                            ProteinRate = 0m,
                            Status = 0,
                            Type = 11
                        },
                        new
                        {
                            Id = 33,
                            Calorie = 30m,
                            CarbRate = 7.5m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(903),
                            FatRate = 0m,
                            Name = "Ice Tea",
                            ProteinRate = 0m,
                            Status = 0,
                            Type = 11
                        },
                        new
                        {
                            Id = 34,
                            Calorie = 37m,
                            CarbRate = 3.5m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(904),
                            FatRate = 2m,
                            Name = "Ayran",
                            ProteinRate = 1.7m,
                            Status = 0,
                            Type = 4
                        },
                        new
                        {
                            Id = 35,
                            Calorie = 299m,
                            CarbRate = 79.2m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(905),
                            FatRate = 0.5m,
                            Name = "Kuru Üzüm",
                            ProteinRate = 3.1m,
                            Status = 0,
                            Type = 1
                        },
                        new
                        {
                            Id = 36,
                            Calorie = 241m,
                            CarbRate = 62.6m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(907),
                            FatRate = 0.5m,
                            Name = "Kuru Kayısı",
                            ProteinRate = 3.4m,
                            Status = 0,
                            Type = 1
                        },
                        new
                        {
                            Id = 37,
                            Calorie = 654m,
                            CarbRate = 13.7m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(908),
                            FatRate = 65.2m,
                            Name = "Ceviz",
                            ProteinRate = 15.2m,
                            Status = 0,
                            Type = 12
                        },
                        new
                        {
                            Id = 38,
                            Calorie = 628m,
                            CarbRate = 16.7m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(909),
                            FatRate = 60.8m,
                            Name = "Fındık",
                            ProteinRate = 15m,
                            Status = 0,
                            Type = 12
                        },
                        new
                        {
                            Id = 39,
                            Calorie = 567m,
                            CarbRate = 16.1m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(911),
                            FatRate = 49.2m,
                            Name = "Fıstık",
                            ProteinRate = 25.8m,
                            Status = 0,
                            Type = 12
                        },
                        new
                        {
                            Id = 40,
                            Calorie = 52m,
                            CarbRate = 13.8m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(912),
                            FatRate = 0.2m,
                            Name = "Yeşil Elma",
                            ProteinRate = 0.3m,
                            Status = 0,
                            Type = 1
                        },
                        new
                        {
                            Id = 41,
                            Calorie = 546m,
                            CarbRate = 45m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(913),
                            FatRate = 31m,
                            Name = "Bitter Çikolata",
                            ProteinRate = 5m,
                            Status = 0,
                            Type = 13
                        },
                        new
                        {
                            Id = 42,
                            Calorie = 2m,
                            CarbRate = 0m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(915),
                            FatRate = 0m,
                            Name = "Türk Kahvesi",
                            ProteinRate = 0.1m,
                            Status = 0,
                            Type = 14
                        },
                        new
                        {
                            Id = 43,
                            Calorie = 1m,
                            CarbRate = 0m,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(916),
                            FatRate = 0m,
                            Name = "Filtre Kahve",
                            ProteinRate = 0.1m,
                            Status = 0,
                            Type = 14
                        });
                });

            modelBuilder.Entity("YemekKalori.Domain.Entities.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("MealCalorie")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("MealTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("Type")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Meals", (string)null);
                });

            modelBuilder.Entity("YemekKalori.Domain.Entities.MealFood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Calorie")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CarbRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FatRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<int?>("MealId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Portion")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ProteinRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.HasIndex("MealId");

                    b.ToTable("MealFood", (string)null);
                });

            modelBuilder.Entity("YemekKalori.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal?>("BMI")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("decimal(18,2)")
                        .HasComputedColumnSql("CAST([Weight] / POWER([Height], 2) AS DECIMAL(18,2))", true);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Diet")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Goal")
                        .HasColumnType("int");

                    b.Property<decimal?>("HedefKalori")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Height")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal?>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 11, 30, 21, 26, 8, 672, DateTimeKind.Local).AddTicks(185),
                            FirstName = "Admin",
                            Height = 0m,
                            LastName = "Admin",
                            Password = "58baaad7621b8a0cb23d3bfb98721cc6d1521b1a9832bdaac29b5d2493026173",
                            Salt = "/GJBwxJ3Dw6msTo6v0Oq1oy9FJwDKOZzw5t6P0D/0yM=",
                            Status = 1,
                            Type = 1,
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("YemekKalori.Domain.Entities.Meal", b =>
                {
                    b.HasOne("YemekKalori.Domain.Entities.User", "User")
                        .WithMany("UserMeals")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("YemekKalori.Domain.Entities.MealFood", b =>
                {
                    b.HasOne("YemekKalori.Domain.Entities.Food", "Food")
                        .WithMany("MealFoods")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YemekKalori.Domain.Entities.Meal", "Meal")
                        .WithMany("MealFoods")
                        .HasForeignKey("MealId");

                    b.Navigation("Food");

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("YemekKalori.Domain.Entities.Food", b =>
                {
                    b.Navigation("MealFoods");
                });

            modelBuilder.Entity("YemekKalori.Domain.Entities.Meal", b =>
                {
                    b.Navigation("MealFoods");
                });

            modelBuilder.Entity("YemekKalori.Domain.Entities.User", b =>
                {
                    b.Navigation("UserMeals");
                });
#pragma warning restore 612, 618
        }
    }
}
