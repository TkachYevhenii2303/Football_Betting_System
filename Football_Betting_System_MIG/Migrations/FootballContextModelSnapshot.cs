﻿// <auto-generated />
using System;
using Football_Betting_System_DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Football_Betting_System_MIG.Migrations
{
    [DbContext(typeof(FootballContext))]
    partial class FootballContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Football_Betting_System_DAL.Entities.Bets", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Games_ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Predictions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Users_ID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("Games_ID");

                    b.HasIndex("Users_ID");

                    b.ToTable("Bets");
                });

            modelBuilder.Entity("Football_Betting_System_DAL.Entities.Colors", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Colors_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Football_Betting_System_DAL.Entities.Countries", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Countries_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Football_Betting_System_DAL.Entities.Games", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Away_teams_Bet_Rate")
                        .HasColumnType("int");

                    b.Property<Guid?>("Away_teams_ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Games_Types")
                        .HasColumnType("int");

                    b.Property<int>("Home_teams_Bet_Rate")
                        .HasColumnType("int");

                    b.Property<Guid?>("Home_teams_ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("Away_teams_ID");

                    b.HasIndex("Home_teams_ID");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Football_Betting_System_DAL.Entities.Players", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Command_number")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Is_Injured")
                        .HasColumnType("bit");

                    b.Property<string>("Players_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PositionsID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Positions_ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TeamsID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Teams_ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("PositionsID");

                    b.HasIndex("TeamsID");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Football_Betting_System_DAL.Entities.PlayersStatistics", b =>
                {
                    b.Property<Guid?>("Playes_ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Games_ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Assist")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("Minutes_Playing")
                        .HasColumnType("int");

                    b.Property<int>("Scored_Goals")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Playes_ID", "Games_ID");

                    b.HasIndex("Games_ID");

                    b.ToTable("PlayersStatistics");
                });

            modelBuilder.Entity("Football_Betting_System_DAL.Entities.Positions", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Positions_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Football_Betting_System_DAL.Entities.Teams", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Away_colors_ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Budget")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("Home_colors_ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Initials")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logos_URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Teams_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TownsID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Towns_ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("Away_colors_ID");

                    b.HasIndex("Home_colors_ID");

                    b.HasIndex("TownsID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Football_Betting_System_DAL.Entities.Towns", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CountriesID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Countries_ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Towns_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CountriesID");

                    b.ToTable("Towns");
                });

            modelBuilder.Entity("Football_Betting_System_DAL.Entities.Users", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Balance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Football_Betting_System_DAL.Entities.Bets", b =>
                {
                    b.HasOne("Football_Betting_System_DAL.Entities.Games", "Games")
                        .WithMany("Bets")
                        .HasForeignKey("Games_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Football_Betting_System_DAL.Entities.Users", "Users")
                        .WithMany("Bets")
                        .HasForeignKey("Users_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Games");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Football_Betting_System_DAL.Entities.Games", b =>
                {
                    b.HasOne("Football_Betting_System_DAL.Entities.Teams", "Away_teams")
                        .WithMany("Away_games")
                        .HasForeignKey("Away_teams_ID");

                    b.HasOne("Football_Betting_System_DAL.Entities.Teams", "Home_teams")
                        .WithMany("Home_games")
                        .HasForeignKey("Home_teams_ID");

                    b.Navigation("Away_teams");

                    b.Navigation("Home_teams");
                });

            modelBuilder.Entity("Football_Betting_System_DAL.Entities.Players", b =>
                {
                    b.HasOne("Football_Betting_System_DAL.Entities.Positions", "Positions")
                        .WithMany()
                        .HasForeignKey("PositionsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Football_Betting_System_DAL.Entities.Teams", "Teams")
                        .WithMany()
                        .HasForeignKey("TeamsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Positions");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("Football_Betting_System_DAL.Entities.PlayersStatistics", b =>
                {
                    b.HasOne("Football_Betting_System_DAL.Entities.Games", "Games")
                        .WithMany("PlayersStatistics")
                        .HasForeignKey("Games_ID")
                        .IsRequired();

                    b.HasOne("Football_Betting_System_DAL.Entities.Players", "Players")
                        .WithMany("PlayersStatistics")
                        .HasForeignKey("Playes_ID")
                        .IsRequired();

                    b.Navigation("Games");

                    b.Navigation("Players");
                });

            modelBuilder.Entity("Football_Betting_System_DAL.Entities.Teams", b =>
                {
                    b.HasOne("Football_Betting_System_DAL.Entities.Colors", "Away_colors")
                        .WithMany("Away_teams")
                        .HasForeignKey("Away_colors_ID");

                    b.HasOne("Football_Betting_System_DAL.Entities.Colors", "Home_colors")
                        .WithMany("Home_teams")
                        .HasForeignKey("Home_colors_ID");

                    b.HasOne("Football_Betting_System_DAL.Entities.Towns", "Towns")
                        .WithMany()
                        .HasForeignKey("TownsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Away_colors");

                    b.Navigation("Home_colors");

                    b.Navigation("Towns");
                });

            modelBuilder.Entity("Football_Betting_System_DAL.Entities.Towns", b =>
                {
                    b.HasOne("Football_Betting_System_DAL.Entities.Countries", "Countries")
                        .WithMany("Towns")
                        .HasForeignKey("CountriesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Countries");
                });

            modelBuilder.Entity("Football_Betting_System_DAL.Entities.Colors", b =>
                {
                    b.Navigation("Away_teams");

                    b.Navigation("Home_teams");
                });

            modelBuilder.Entity("Football_Betting_System_DAL.Entities.Countries", b =>
                {
                    b.Navigation("Towns");
                });

            modelBuilder.Entity("Football_Betting_System_DAL.Entities.Games", b =>
                {
                    b.Navigation("Bets");

                    b.Navigation("PlayersStatistics");
                });

            modelBuilder.Entity("Football_Betting_System_DAL.Entities.Players", b =>
                {
                    b.Navigation("PlayersStatistics");
                });

            modelBuilder.Entity("Football_Betting_System_DAL.Entities.Teams", b =>
                {
                    b.Navigation("Away_games");

                    b.Navigation("Home_games");
                });

            modelBuilder.Entity("Football_Betting_System_DAL.Entities.Users", b =>
                {
                    b.Navigation("Bets");
                });
#pragma warning restore 612, 618
        }
    }
}
