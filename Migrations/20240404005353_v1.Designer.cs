﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project_XemPhim.DataContext;

#nullable disable

namespace Project_XemPhim.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240404005353_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Project_XemPhim.entity.Banner", b =>
                {
                    b.Property<int>("Id_Banner")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Banner"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Banner");

                    b.ToTable("Banner");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Bill", b =>
                {
                    b.Property<int>("Id_Bill")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Bill"));

                    b.Property<int>("BillStatusId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PromotionId")
                        .HasColumnType("int");

                    b.Property<double>("TotalMoney")
                        .HasColumnType("float");

                    b.Property<string>("TradingCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId_User")
                        .HasColumnType("int");

                    b.HasKey("Id_Bill");

                    b.HasIndex("BillStatusId");

                    b.HasIndex("PromotionId");

                    b.HasIndex("UserId_User");

                    b.ToTable("Bill");
                });

            modelBuilder.Entity("Project_XemPhim.entity.BillFood", b =>
                {
                    b.Property<int>("Id_BillFood")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_BillFood"));

                    b.Property<int>("BillId")
                        .HasColumnType("int");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id_BillFood");

                    b.HasIndex("BillId");

                    b.HasIndex("FoodId");

                    b.ToTable("BillFood");
                });

            modelBuilder.Entity("Project_XemPhim.entity.BillStatus", b =>
                {
                    b.Property<int>("Id_BillStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_BillStatus"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_BillStatus");

                    b.ToTable("BillStatus");
                });

            modelBuilder.Entity("Project_XemPhim.entity.BillTicket", b =>
                {
                    b.Property<int>("Id_BillTicket")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_BillTicket"));

                    b.Property<int>("BillId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.HasKey("Id_BillTicket");

                    b.HasIndex("BillId");

                    b.HasIndex("TicketId");

                    b.ToTable("BillTicket");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Cinema", b =>
                {
                    b.Property<int>("Id_Cinema")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Cinema"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("NameOfCinema")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Cinema");

                    b.ToTable("Cinema");
                });

            modelBuilder.Entity("Project_XemPhim.entity.ConfirmEmail", b =>
                {
                    b.Property<int>("Id_ConfirmEmail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_ConfirmEmail"));

                    b.Property<string>("ConfirmCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpiredTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsConfirm")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id_ConfirmEmail");

                    b.HasIndex("UserId");

                    b.ToTable("ConfirmEmail");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Food", b =>
                {
                    b.Property<int>("Id_Food")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Food"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("NameOfFood")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id_Food");

                    b.ToTable("Food");
                });

            modelBuilder.Entity("Project_XemPhim.entity.GeneralSetting", b =>
                {
                    b.Property<int>("Id_GeneralSetting")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_GeneralSetting"));

                    b.Property<DateTime>("BreakTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("BusinessHours")
                        .HasColumnType("int");

                    b.Property<DateTime>("CloseTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("FixedTicketPrice")
                        .HasColumnType("float");

                    b.Property<int>("PercentDay")
                        .HasColumnType("int");

                    b.Property<int>("PercentWeekend")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeBeginToChange")
                        .HasColumnType("datetime2");

                    b.HasKey("Id_GeneralSetting");

                    b.ToTable("GeneralSetting");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Movie", b =>
                {
                    b.Property<int>("Id_Moive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Moive"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("HeroImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieDuration")
                        .HasColumnType("int");

                    b.Property<int>("MovieTypeId_MovieType")
                        .HasColumnType("int");

                    b.Property<int>("MovieTypedId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PremiereDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RateId")
                        .HasColumnType("int");

                    b.Property<string>("Trailer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Moive");

                    b.HasIndex("MovieTypeId_MovieType");

                    b.HasIndex("RateId");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("Project_XemPhim.entity.MovieType", b =>
                {
                    b.Property<int>("Id_MovieType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_MovieType"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MoiveTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_MovieType");

                    b.ToTable("MovieType");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Promotion", b =>
                {
                    b.Property<int>("Id_Promotion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Promotion"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Percent")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("RankCustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Promotion");

                    b.HasIndex("RankCustomerId");

                    b.ToTable("Promotion");
                });

            modelBuilder.Entity("Project_XemPhim.entity.RankCustomer", b =>
                {
                    b.Property<int>("Id_RankCustomer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_RankCustomer"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.HasKey("Id_RankCustomer");

                    b.ToTable("RankCustomer");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Rate", b =>
                {
                    b.Property<int>("Id_Rate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Rate"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Rate");

                    b.ToTable("Rate");
                });

            modelBuilder.Entity("Project_XemPhim.entity.RefreshToken", b =>
                {
                    b.Property<int>("Id_RefreshToken")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_RefreshToken"));

                    b.Property<DateTime>("ExpiredTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id_RefreshToken");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshToken");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Role", b =>
                {
                    b.Property<int>("Id_Role")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Role"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Role");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Room", b =>
                {
                    b.Property<int>("Id_Room")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Room"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("CinemaId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CinemaId_Cinema")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id_Room");

                    b.HasIndex("CinemaId_Cinema");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Schedule", b =>
                {
                    b.Property<int>("Id_Shedule")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Shedule"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id_Shedule");

                    b.HasIndex("MovieId");

                    b.HasIndex("RoomId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Seat", b =>
                {
                    b.Property<int>("Id_Seat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Seat"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Line")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("SeatStatusId")
                        .HasColumnType("int");

                    b.Property<int>("SeatTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id_Seat");

                    b.HasIndex("RoomId");

                    b.HasIndex("SeatStatusId");

                    b.HasIndex("SeatTypeId");

                    b.ToTable("Seat");
                });

            modelBuilder.Entity("Project_XemPhim.entity.SeatStatus", b =>
                {
                    b.Property<int>("Id_SeatStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_SeatStatus"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_SeatStatus");

                    b.ToTable("SeatStatus");
                });

            modelBuilder.Entity("Project_XemPhim.entity.SeatType", b =>
                {
                    b.Property<int>("Id_SeatType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_SeatType"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_SeatType");

                    b.ToTable("SeatType");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Ticket", b =>
                {
                    b.Property<int>("Id_Ticket")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Ticket"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<double>("PriceTicket")
                        .HasColumnType("float");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.HasKey("Id_Ticket");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("SeatId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("Project_XemPhim.entity.User", b =>
                {
                    b.Property<int>("Id_User")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_User"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.Property<int>("RankCustomerId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserStatusId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_User");

                    b.HasIndex("RankCustomerId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserStatusId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Project_XemPhim.entity.UserStatus", b =>
                {
                    b.Property<int>("Id_UserStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_UserStatus"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_UserStatus");

                    b.ToTable("UserStatus");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Bill", b =>
                {
                    b.HasOne("Project_XemPhim.entity.BillStatus", "BillStatus")
                        .WithMany("bills")
                        .HasForeignKey("BillStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_XemPhim.entity.Promotion", "Promotion")
                        .WithMany("bills")
                        .HasForeignKey("PromotionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_XemPhim.entity.User", "User")
                        .WithMany("bills")
                        .HasForeignKey("UserId_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BillStatus");

                    b.Navigation("Promotion");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Project_XemPhim.entity.BillFood", b =>
                {
                    b.HasOne("Project_XemPhim.entity.Bill", "Bill")
                        .WithMany("billFoods")
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_XemPhim.entity.Food", "Food")
                        .WithMany("billFoods")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Food");
                });

            modelBuilder.Entity("Project_XemPhim.entity.BillTicket", b =>
                {
                    b.HasOne("Project_XemPhim.entity.Bill", "Bill")
                        .WithMany("billTickets")
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_XemPhim.entity.Ticket", "Ticket")
                        .WithMany("billTickets")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("Project_XemPhim.entity.ConfirmEmail", b =>
                {
                    b.HasOne("Project_XemPhim.entity.User", "User")
                        .WithMany("confirmEmails")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Movie", b =>
                {
                    b.HasOne("Project_XemPhim.entity.MovieType", "MovieType")
                        .WithMany("movies")
                        .HasForeignKey("MovieTypeId_MovieType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_XemPhim.entity.Rate", "Rate")
                        .WithMany("movies")
                        .HasForeignKey("RateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MovieType");

                    b.Navigation("Rate");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Promotion", b =>
                {
                    b.HasOne("Project_XemPhim.entity.RankCustomer", "RankCustomer")
                        .WithMany("promotions")
                        .HasForeignKey("RankCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RankCustomer");
                });

            modelBuilder.Entity("Project_XemPhim.entity.RefreshToken", b =>
                {
                    b.HasOne("Project_XemPhim.entity.User", "user")
                        .WithMany("refreshTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Room", b =>
                {
                    b.HasOne("Project_XemPhim.entity.Cinema", "Cinema")
                        .WithMany("rooms")
                        .HasForeignKey("CinemaId_Cinema")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Schedule", b =>
                {
                    b.HasOne("Project_XemPhim.entity.Movie", "Movie")
                        .WithMany("schedules")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_XemPhim.entity.Room", "Room")
                        .WithMany("schedules")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Seat", b =>
                {
                    b.HasOne("Project_XemPhim.entity.Room", "Room")
                        .WithMany("seats")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_XemPhim.entity.SeatStatus", "SeatStatus")
                        .WithMany("seats")
                        .HasForeignKey("SeatStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_XemPhim.entity.SeatType", "SeatType")
                        .WithMany("seats")
                        .HasForeignKey("SeatTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");

                    b.Navigation("SeatStatus");

                    b.Navigation("SeatType");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Ticket", b =>
                {
                    b.HasOne("Project_XemPhim.entity.Schedule", "Schedule")
                        .WithMany("tickets")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_XemPhim.entity.Seat", "Seat")
                        .WithMany("tickets")
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Schedule");

                    b.Navigation("Seat");
                });

            modelBuilder.Entity("Project_XemPhim.entity.User", b =>
                {
                    b.HasOne("Project_XemPhim.entity.RankCustomer", "RankCustomer")
                        .WithMany("users")
                        .HasForeignKey("RankCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_XemPhim.entity.Role", "Role")
                        .WithMany("users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_XemPhim.entity.UserStatus", "UserStatus")
                        .WithMany("users")
                        .HasForeignKey("UserStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RankCustomer");

                    b.Navigation("Role");

                    b.Navigation("UserStatus");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Bill", b =>
                {
                    b.Navigation("billFoods");

                    b.Navigation("billTickets");
                });

            modelBuilder.Entity("Project_XemPhim.entity.BillStatus", b =>
                {
                    b.Navigation("bills");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Cinema", b =>
                {
                    b.Navigation("rooms");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Food", b =>
                {
                    b.Navigation("billFoods");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Movie", b =>
                {
                    b.Navigation("schedules");
                });

            modelBuilder.Entity("Project_XemPhim.entity.MovieType", b =>
                {
                    b.Navigation("movies");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Promotion", b =>
                {
                    b.Navigation("bills");
                });

            modelBuilder.Entity("Project_XemPhim.entity.RankCustomer", b =>
                {
                    b.Navigation("promotions");

                    b.Navigation("users");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Rate", b =>
                {
                    b.Navigation("movies");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Role", b =>
                {
                    b.Navigation("users");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Room", b =>
                {
                    b.Navigation("schedules");

                    b.Navigation("seats");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Schedule", b =>
                {
                    b.Navigation("tickets");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Seat", b =>
                {
                    b.Navigation("tickets");
                });

            modelBuilder.Entity("Project_XemPhim.entity.SeatStatus", b =>
                {
                    b.Navigation("seats");
                });

            modelBuilder.Entity("Project_XemPhim.entity.SeatType", b =>
                {
                    b.Navigation("seats");
                });

            modelBuilder.Entity("Project_XemPhim.entity.Ticket", b =>
                {
                    b.Navigation("billTickets");
                });

            modelBuilder.Entity("Project_XemPhim.entity.User", b =>
                {
                    b.Navigation("bills");

                    b.Navigation("confirmEmails");

                    b.Navigation("refreshTokens");
                });

            modelBuilder.Entity("Project_XemPhim.entity.UserStatus", b =>
                {
                    b.Navigation("users");
                });
#pragma warning restore 612, 618
        }
    }
}
