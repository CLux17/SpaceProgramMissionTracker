using Microsoft.EntityFrameworkCore.Migrations;

namespace SpaceProgramMissionTracker.Migrations
{
    public partial class changedagencyname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Agencies",
                newName: "AgencyName");

            migrationBuilder.AddColumn<string>(
                name: "AgencyName",
                table: "Missions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgencyName",
                table: "Missions");

            migrationBuilder.RenameColumn(
                name: "AgencyName",
                table: "Agencies",
                newName: "Name");
        }
    }
}
