using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Football.DAL.Migrations
{
    /// <inheritdoc />
    public partial class TeamsColumnsAddition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LoosedGoals",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ScoredGoals",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoosedGoals",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ScoredGoals",
                table: "Teams");
        }
    }
}
