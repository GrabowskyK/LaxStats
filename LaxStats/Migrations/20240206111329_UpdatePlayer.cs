using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaxStats.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePlayer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Assist",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GamePlayed",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Goal",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MinutesPenalties",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Penalties",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShirtNumber",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Assist",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "GamePlayed",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Goal",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "MinutesPenalties",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Penalties",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "ShirtNumber",
                table: "Players");
        }
    }
}
