using Microsoft.EntityFrameworkCore.Migrations;

namespace SpaceProgramMissionTracker.Migrations
{
    public partial class newphotoforrussians : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "MissionId",
                keyValue: 2,
                column: "ImageURL",
                value: "https://cosmos-magazine.imgix.net/file/spina/photo/10451/170517_Venera_7_Assembly.jpg?fit=clip&w=835");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "MissionId",
                keyValue: 2,
                column: "ImageURL",
                value: "");
        }
    }
}
