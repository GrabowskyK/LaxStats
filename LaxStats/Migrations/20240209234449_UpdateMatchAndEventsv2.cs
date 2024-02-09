using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaxStats.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMatchAndEventsv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "EventPenalties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "EventGoals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EventPenalties_MatchId",
                table: "EventPenalties",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_EventGoals_MatchId",
                table: "EventGoals",
                column: "MatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventGoals_Matches_MatchId",
                table: "EventGoals",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventPenalties_Matches_MatchId",
                table: "EventPenalties",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventGoals_Matches_MatchId",
                table: "EventGoals");

            migrationBuilder.DropForeignKey(
                name: "FK_EventPenalties_Matches_MatchId",
                table: "EventPenalties");

            migrationBuilder.DropIndex(
                name: "IX_EventPenalties_MatchId",
                table: "EventPenalties");

            migrationBuilder.DropIndex(
                name: "IX_EventGoals_MatchId",
                table: "EventGoals");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "EventPenalties");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "EventGoals");
        }
    }
}
