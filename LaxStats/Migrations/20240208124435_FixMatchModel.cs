using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaxStats.Migrations
{
    /// <inheritdoc />
    public partial class FixMatchModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LeagueId",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Matches_LeagueId",
                table: "Matches",
                column: "LeagueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Leagues_LeagueId",
                table: "Matches",
                column: "LeagueId",
                principalTable: "Leagues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Leagues_LeagueId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_LeagueId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "LeagueId",
                table: "Matches");
        }
    }
}
