using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaxStats.Migrations
{
    /// <inheritdoc />
    public partial class TeamsInLeagueFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamsInLeague_Leagues_LeagueId",
                table: "TeamsInLeague");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamsInLeague_Teams_TeamId",
                table: "TeamsInLeague");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamsInLeague",
                table: "TeamsInLeague");

            migrationBuilder.RenameTable(
                name: "TeamsInLeague",
                newName: "TeamsInLeagues");

            migrationBuilder.RenameIndex(
                name: "IX_TeamsInLeague_TeamId",
                table: "TeamsInLeagues",
                newName: "IX_TeamsInLeagues_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_TeamsInLeague_LeagueId",
                table: "TeamsInLeagues",
                newName: "IX_TeamsInLeagues_LeagueId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamsInLeagues",
                table: "TeamsInLeagues",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamsInLeagues_Leagues_LeagueId",
                table: "TeamsInLeagues",
                column: "LeagueId",
                principalTable: "Leagues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamsInLeagues_Teams_TeamId",
                table: "TeamsInLeagues",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamsInLeagues_Leagues_LeagueId",
                table: "TeamsInLeagues");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamsInLeagues_Teams_TeamId",
                table: "TeamsInLeagues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamsInLeagues",
                table: "TeamsInLeagues");

            migrationBuilder.RenameTable(
                name: "TeamsInLeagues",
                newName: "TeamsInLeague");

            migrationBuilder.RenameIndex(
                name: "IX_TeamsInLeagues_TeamId",
                table: "TeamsInLeague",
                newName: "IX_TeamsInLeague_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_TeamsInLeagues_LeagueId",
                table: "TeamsInLeague",
                newName: "IX_TeamsInLeague_LeagueId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamsInLeague",
                table: "TeamsInLeague",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamsInLeague_Leagues_LeagueId",
                table: "TeamsInLeague",
                column: "LeagueId",
                principalTable: "Leagues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamsInLeague_Teams_TeamId",
                table: "TeamsInLeague",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
