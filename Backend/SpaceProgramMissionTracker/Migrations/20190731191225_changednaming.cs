using Microsoft.EntityFrameworkCore.Migrations;

namespace SpaceProgramMissionTracker.Migrations
{
    public partial class changednaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgencyName",
                table: "Missions");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "StellarBodies",
                newName: "StellarBodyName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Missions",
                newName: "MissionName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StellarBodyName",
                table: "StellarBodies",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MissionName",
                table: "Missions",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "AgencyName",
                table: "Missions",
                nullable: true);
        }
    }
}
