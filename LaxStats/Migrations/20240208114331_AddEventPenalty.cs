using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaxStats.Migrations
{
    /// <inheritdoc />
    public partial class AddEventPenalty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventPenalties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeEvent = table.Column<TimeSpan>(type: "time", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    PenaltyType = table.Column<int>(type: "int", nullable: false),
                    TimePenalty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventPenalties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventPenalties_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventPenalties_PlayerId",
                table: "EventPenalties",
                column: "PlayerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventPenalties");
        }
    }
}
