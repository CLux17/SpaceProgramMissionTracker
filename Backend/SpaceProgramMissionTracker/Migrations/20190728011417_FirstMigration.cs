using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpaceProgramMissionTracker.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agencies",
                columns: table => new
                {
                    AgencyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencies", x => x.AgencyId);
                });

            migrationBuilder.CreateTable(
                name: "StellarBodies",
                columns: table => new
                {
                    StellarBodyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StellarBodies", x => x.StellarBodyId);
                });

            migrationBuilder.CreateTable(
                name: "Missions",
                columns: table => new
                {
                    MissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    AgencyId = table.Column<int>(nullable: false),
                    StellarBodyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missions", x => x.MissionId);
                    table.ForeignKey(
                        name: "FK_Missions_Agencies_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "Agencies",
                        principalColumn: "AgencyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Missions_StellarBodies_StellarBodyId",
                        column: x => x.StellarBodyId,
                        principalTable: "StellarBodies",
                        principalColumn: "StellarBodyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Agencies",
                columns: new[] { "AgencyId", "Name" },
                values: new object[,]
                {
                    { 1, "NASA" },
                    { 2, "Roscosmos" },
                    { 3, "ESA" },
                    { 4, "SpaceX" }
                });

            migrationBuilder.InsertData(
                table: "StellarBodies",
                columns: new[] { "StellarBodyId", "Name" },
                values: new object[,]
                {
                    { 1, "Moon" },
                    { 2, "Venus" },
                    { 3, "Comet" },
                    { 4, "LEO" }
                });

            migrationBuilder.InsertData(
                table: "Missions",
                columns: new[] { "MissionId", "AgencyId", "Name", "StellarBodyId" },
                values: new object[,]
                {
                    { 1, 1, "Apollo", 1 },
                    { 2, 2, "Venera", 2 },
                    { 3, 3, "Philae", 3 },
                    { 4, 4, "ISS Resupply", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Missions_AgencyId",
                table: "Missions",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Missions_StellarBodyId",
                table: "Missions",
                column: "StellarBodyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Missions");

            migrationBuilder.DropTable(
                name: "Agencies");

            migrationBuilder.DropTable(
                name: "StellarBodies");
        }
    }
}
