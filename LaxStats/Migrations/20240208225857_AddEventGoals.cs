using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaxStats.Migrations
{
    /// <inheritdoc />
    public partial class AddEventGoals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventGoals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeGoal = table.Column<TimeSpan>(type: "time", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    AssistId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventGoals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventGoals_Players_AssistId",
                        column: x => x.AssistId,
                        principalTable: "Players",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EventGoals_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventGoals_AssistId",
                table: "EventGoals",
                column: "AssistId");

            migrationBuilder.CreateIndex(
                name: "IX_EventGoals_PlayerId",
                table: "EventGoals",
                column: "PlayerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventGoals");
        }
    }
}
