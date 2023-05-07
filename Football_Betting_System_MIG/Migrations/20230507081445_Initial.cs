using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Football_Betting_System_MIG.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Colors_title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Countries_title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Positions_title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Balance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Towns_title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountriesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Countries_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Towns_Countries_CountriesID",
                        column: x => x.CountriesID,
                        principalTable: "Countries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Teams_title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logos_URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Initials = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Budget = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TownsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Towns_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Home_colors_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Away_colors_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Teams_Colors_Away_colors_ID",
                        column: x => x.Away_colors_ID,
                        principalTable: "Colors",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Teams_Colors_Home_colors_ID",
                        column: x => x.Home_colors_ID,
                        principalTable: "Colors",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Teams_Towns_TownsID",
                        column: x => x.TownsID,
                        principalTable: "Towns",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Games_Types = table.Column<int>(type: "int", nullable: false),
                    Home_teams_Bet_Rate = table.Column<int>(type: "int", nullable: false),
                    Away_teams_Bet_Rate = table.Column<int>(type: "int", nullable: false),
                    Home_teams_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Away_teams_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Games_Teams_Away_teams_ID",
                        column: x => x.Away_teams_ID,
                        principalTable: "Teams",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Games_Teams_Home_teams_ID",
                        column: x => x.Home_teams_ID,
                        principalTable: "Teams",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Players_title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Command_number = table.Column<int>(type: "int", nullable: false),
                    Is_Injured = table.Column<bool>(type: "bit", nullable: false),
                    TeamsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Teams_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PositionsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Positions_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Players_Positions_PositionsID",
                        column: x => x.PositionsID,
                        principalTable: "Positions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamsID",
                        column: x => x.TeamsID,
                        principalTable: "Teams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bets",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Predictions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Games_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Users_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bets_Games_Games_ID",
                        column: x => x.Games_ID,
                        principalTable: "Games",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bets_Users_Users_ID",
                        column: x => x.Users_ID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayersStatistics",
                columns: table => new
                {
                    Playes_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Games_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Assist = table.Column<int>(type: "int", nullable: false),
                    Minutes_Playing = table.Column<int>(type: "int", nullable: false),
                    Scored_Goals = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayersStatistics", x => new { x.Playes_ID, x.Games_ID });
                    table.ForeignKey(
                        name: "FK_PlayersStatistics_Games_Games_ID",
                        column: x => x.Games_ID,
                        principalTable: "Games",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PlayersStatistics_Players_Playes_ID",
                        column: x => x.Playes_ID,
                        principalTable: "Players",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bets_Games_ID",
                table: "Bets",
                column: "Games_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Bets_Users_ID",
                table: "Bets",
                column: "Users_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Away_teams_ID",
                table: "Games",
                column: "Away_teams_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Home_teams_ID",
                table: "Games",
                column: "Home_teams_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Players_PositionsID",
                table: "Players",
                column: "PositionsID");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamsID",
                table: "Players",
                column: "TeamsID");

            migrationBuilder.CreateIndex(
                name: "IX_PlayersStatistics_Games_ID",
                table: "PlayersStatistics",
                column: "Games_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Away_colors_ID",
                table: "Teams",
                column: "Away_colors_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Home_colors_ID",
                table: "Teams",
                column: "Home_colors_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_TownsID",
                table: "Teams",
                column: "TownsID");

            migrationBuilder.CreateIndex(
                name: "IX_Towns_CountriesID",
                table: "Towns",
                column: "CountriesID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bets");

            migrationBuilder.DropTable(
                name: "PlayersStatistics");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Towns");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
