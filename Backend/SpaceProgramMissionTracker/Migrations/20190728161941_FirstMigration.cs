﻿using Microsoft.EntityFrameworkCore.Metadata;
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
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true)
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
                    Name = table.Column<string>(nullable: true),
                    Classification = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true)
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
                    Description = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true),
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

            migrationBuilder.CreateTable(
                name: "MissionNumbers",
                columns: table => new
                {
                    MissionNumberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MissionIterationNumber = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    MissionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissionNumbers", x => x.MissionNumberId);
                    table.ForeignKey(
                        name: "FK_MissionNumbers_Missions_MissionId",
                        column: x => x.MissionId,
                        principalTable: "Missions",
                        principalColumn: "MissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Agencies",
                columns: new[] { "AgencyId", "Description", "ImageURL", "Name" },
                values: new object[,]
                {
                    { 1, "The National Aeronautics and Space Administration is an independent agency of the United States Federal Government responsible for the civilian space program, as well as aeronautics and aerospace research. NASA was established in 1958, succeeding the National Advisory Committee for Aeronautics(NACA).The new agency was to have a distinctly civilian orientation, encouraging peaceful applications in space science. Since its establishment, most US space exploration efforts have been led by NASA, including the Apollo Moon landing missions, the Skylab space station, and later the Space Shuttle.NASA is supporting the International Space Station and is overseeing the development of the Orion Multi - Purpose Crew Vehicle, the Space Launch System and Commercial Crew vehicles.The agency is also responsible for the Launch Services Program which provides oversight of launch operations and countdown management for unmanned NASA launches.", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/NASA_logo.svg/800px-NASA_logo.svg.png", "NASA" },
                    { 2, "The Roscosmos State Corporation for Space Activities (Russian: Государственная корпорация по космической деятельности «Роскосмос», Gosudarstvyennaya korporaciya po kosmicheskoy dyeyatyel'nosti \"Roskosmos\"), commonly known as Roscosmos (Russian: Роскосмос), is a state corporation responsible for the wide range and types of space flights and cosmonautics programs for the Russian Federation. Originally part of the Federal Space Agency(Russian: Федеральное космическое агентство, Federal'noye kosmicheskoye agentstvo), the corporation evolved and consolidated itself to the national state corporation on 28 December 2015 through a presidential decree. Before, since 1992, Roscosmos was a part of the Russian Aviation and Space Agency (Russian: Российское авиационно-космическое агентство, Rossiyskoe aviatsionno-kosmicheskoe agentstvo, commonly known as Rosaviakosmos).", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6e/Roscosmos_logo_en.svg/800px-Roscosmos_logo_en.svg.png", "Roscosmos" },
                    { 3, "The European Space Agency (ESA) is Europe’s gateway to space. Its mission is to shape the development of Europe’s space capability and ensure that investment in space continues to deliver benefits to the citizens of Europe and the world. ESA is an international organisation with 22 Member States.By coordinating the financial and intellectual resources of its members, it can undertake programmes and activities far beyond the scope of any single European country.", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/ESA_logo.svg/1920px-ESA_logo.svg.png", "ESA" },
                    { 4, "As one of the world’s fastest growing providers of launch services, SpaceX has secured over 100 missions to its manifest, representing over $12 billion on contract. These include commercial satellite launches as well as US government missions. SpaceX’s Dragon spacecraft is flying numerous cargo resupply missions to the space station under a series of Commercial Resupply Services contracts. Dragon was designed from the outset to carry humans to space and will soon fly astronauts under NASA’s Commercial Crew Program. Building on the achievements of Falcon 9 and Falcon Heavy, SpaceX is working on a next generation of fully reusable launch vehicles that will be the most powerful ever built, capable of carrying humans to Mars and other destinations in the solar system.", "https://pbs.twimg.com/profile_images/1082744382585856001/rH_k3PtQ_400x400.jpg", "SpaceX" }
                });

            migrationBuilder.InsertData(
                table: "StellarBodies",
                columns: new[] { "StellarBodyId", "Classification", "Description", "ImageURL", "Name" },
                values: new object[,]
                {
                    { 1, "Planet", "The smallest planet in our solar system and nearest to the Sun, Mercury is only slightly larger than Earth's Moon. From the surface of Mercury, the Sun would appear more than three times as large as it does when viewed from Earth, and the sunlight would be as much as seven times brighter. Despite its proximity to the Sun, Mercury is not the hottest planet in our solar system – that title belongs to nearby Venus, thanks to its dense atmosphere. But Mercury is the fastest planet, zipping around the Sun every 88 Earth days. Mercury is appropriately named for the swiftest of the ancient Roman gods.", "https://solarsystem.nasa.gov/system/resources/detail_files/771_PIA16853.jpg", "Mercury" },
                    { 2, "Planet", "Venus is the second planet from the Sun and our closest planetary neighbor. Similar in structure and size to Earth, Venus spins slowly in the opposite direction from most planets. Its thick atmosphere traps heat in a runaway greenhouse effect, making it the hottest planet in our solar system with surface temperatures hot enough to melt lead. Glimpses below the clouds reveal volcanoes and deformed mountains. Venus is named for the ancient Roman goddess of love and beauty, who was known as Aphrodite to the Ancient Greeks.", "https://solarsystem.nasa.gov/system/resources/detail_files/688_Venus.jpg", "Venus" },
                    { 3, "Planet", "Our home planet is the third planet from the Sun, and the only place we know of so far that’s inhabited by living things. While Earth is only the fifth largest planet in the solar system, it is the only world in our solar system with liquid water on the surface. Just slightly larger than nearby Venus, Earth is the biggest of the four planets closest to the Sun, all of which are made of rock and metal. The name Earth is at least 1,000 years old. All of the planets, except for Earth, were named after Greek and Roman gods and goddesses. However, the name Earth is a Germanic word, which simply means “the ground.”", "https://solarsystem.nasa.gov/system/resources/detail_files/786_1-bluemarble_west.jpg", "Earth" },
                    { 4, "Planet", "Mars was named by the ancient Romans for their god of war because its reddish color was reminiscent of blood. Other civilizations also named the planet for this attribute; for example, the Egyptians called it \"Her Desher, \" meaning \"the red one.\" Even today, it is frequently called the \"Red Planet\" because iron minerals in the Martian dirt oxidize, or rust, causing the surface to look red.", "https://solarsystem.nasa.gov/system/resources/detail_files/683_6453_mars-globe-valles-marineris-enhanced-full2.jpg", "Mars" },
                    { 5, "Planet", "Jupiter is the fifth planet from our Sun and is, by far, the largest planet in the solar system – more than twice as massive as all the other planets combined. Jupiter's stripes and swirls are actually cold, windy clouds of ammonia and water, floating in an atmosphere of hydrogen and helium. Jupiter’s iconic Great Red Spot is a giant storm bigger than Earth that has raged for hundreds of years. Jupiter is surrounded by 79 known moons.Scientists are most interested in the Galilean satellites – the four largest moons discovered by Galileo Galilei in 1610: Io, Europa, Ganymede and Callisto. Jupiter also has several rings, but unlike the famous rings of Saturn, Jupiter’s rings are very faint and made of dust, not ice. Jupiter is named for the king of the ancient Roman gods.", "https://solarsystem.nasa.gov/system/resources/detail_files/113_PIA02873.jpg", "Jupiter" },
                    { 6, "Planet", "Saturn is the sixth planet from the Sun and the second largest planet in our solar system. Adorned with a dazzling system of icy rings, Saturn is unique among the planets. It is not the only planet to have rings, but none are as spectacular or as complex as Saturn's. Like fellow gas giant Jupiter, Saturn is a massive ball made mostly of hydrogen and helium. Surrounded by more than 60 known moons, Saturn is home to some of the most fascinating landscapes in our solar system.From the jets of water that spray from Enceladus to the methane lakes on smoggy Titan, the Saturn system is a rich source of scientific discovery and still holds many mysteries. The farthest planet from Earth discovered by the unaided human eye, Saturn has been known since ancient times.The planet is named for the Roman god of agriculture and wealth, who was also the father of Jupiter.", "https://solarsystem.nasa.gov/system/resources/detail_files/17845_PIA12567-800w.jpg", "Saturn" },
                    { 7, "Planet", "The seventh planet from the Sun with the third largest diameter in our solar system, Uranus is very cold and windy. The ice giant is surrounded by 13 faint rings and 27 small moons as it rotates at a nearly 90-degree angle from the plane of its orbit. This unique tilt makes Uranus appear to spin on its side, orbiting the Sun like a rolling ball. The first planet found with the aid of a telescope, Uranus was discovered in 1781 by astronomer William Herschel, although he originally thought it was either a comet or a star.It was two years later that the object was universally accepted as a new planet, in part because of observations by astronomer Johann Elert Bode. William Herschel tried unsuccessfully to name his discovery Georgium Sidus after King George III.Instead the planet was named for Uranus, the Greek god of the sky, as suggested by Johann Bode.", "https://solarsystem.nasa.gov/system/resources/detail_files/454_Hubble_Uranus.jpg", "Uranus" },
                    { 8, "Planet", "Dark, cold and whipped by supersonic winds, ice giant Neptune is the eighth and most distant planet in our solar system. More than 30 times as far from the Sun as Earth, Neptune is the only planet in our solar system not visible to the naked eye. In 2011 Neptune completed its first 165-year orbit since its discovery in 1846. Neptune is so far from the Sun that high noon on the big blue planet would seem like dim twilight to us.The warm light we see here on our home planet is roughly 900 times as bright as sunlight on Neptune. The ice giant Neptune was the first planet located through mathematical calculations.Using predictions made by Urbain Le Verrier, Johann Galle discovered the planet in 1846.The planet is named after the Roman god of the sea, as suggested by Le Verrier", "https://solarsystem.nasa.gov/system/resources/detail_files/611_PIA01492.jpg", "Neptune" },
                    { 9, "Dwarf Planet", "Pluto is a complex and mysterious world with mountains, valleys, plains, craters, and maybe glaciers. Discovered in 1930, Pluto was long considered our solar system's ninth planet. But after the discovery of similar intriguing worlds deeper in the distant Kuiper Belt, icy Pluto was reclassified as a dwarf planet. Pluto is orbited by five known moons, the largest of which is Charon.Charon is about half the size of Pluto itself, making it the largest satellite relative to the planet it orbits in our solar system.Pluto and Charon are often referred to as a \"double planet.\" Pluto is named after the Roman god of the underworld.", "https://solarsystem.nasa.gov/system/resources/detail_files/933_BIG_P_COLOR_2_TRUE_COLOR1_1980.jpg", "Pluto" },
                    { 10, "Moon", "The brightest and largest object in our night sky, the Moon makes Earth a more livable planet by moderating our home planet's wobble on its axis, leading to a relatively stable climate. It also causes tides, creating a rhythm that has guided humans for thousands of years. The Moon was likely formed after a Mars-sized body collided with Earth several billion years ago. Earth's Moon is the only place beyond Earth where humans have set foot, so far. Earth's only natural satellite is simply called \"the Moon\" because people didn't know other moons existed until Galileo Galilei discovered four moons orbiting Jupiter in 1610.In Latin, the Moon was called Luna, which is the main adjective for all things Moon - related: lunar", "https://solarsystem.nasa.gov/system/resources/detail_files/2460_lro_nearside_800.jpg", "Moon" },
                    { 11, "Comet", "ESA's Rosetta mission chased down Comet 67P/Churyumov-Gerasimenko for ten years. The comet is a regular visitor to the inner Solar System, orbiting the Sun once every 6.5 years between the orbits of Jupiter and Earth. Like all comets, Churyumov - Gerasimenko is named after its discoverers.It was first observed in 1969, when several astronomers from Kiev visited the Alma - Ata Astrophysical Institute in Kazakhstan to conduct a survey of comets.", "http://www.esa.int/var/esa/storage/images/esa_multimedia/images/2017/10/comet_in_may_2015/15426565-1-eng-GB/Comet_in_May_2015_node_full_image_2.jpg", "Comet 67P/Churyumov–Gerasimenko" }
                });

            migrationBuilder.InsertData(
                table: "Missions",
                columns: new[] { "MissionId", "AgencyId", "Description", "ImageURL", "Name", "StellarBodyId" },
                values: new object[,]
                {
                    { 2, 2, "The Venera (Russian: Вене́ра, pronounced [vʲɪˈnʲɛrə]) program was the name given to a series of space probes developed by the Soviet Union between 1961 and 1984 to gather information about the planet Venus. Ten probes successfully landed on the surface of the planet, including the two Vega program and Venera-Halley probes, while thirteen probes successfully entered the Venusian atmosphere. Due to the extreme surface conditions on Venus, the probes could only survive for a short period on the surface, with times ranging from 23 minutes to two hours. The Venera program established a number of precedents in human space exploration, among them being the first human-made devices to enter the atmosphere of another planet (Venera 4 on October 18, 1967), the first to make a soft landing on another planet (Venera 7 on December 15, 1970), the first to return images from another planet's surface (Venera 9 on June 8, 1975), and the first to perform high-resolution radar mapping scans.", "", "Venera", 2 },
                    { 4, 4, "In 2005, NASA solicited proposals for a commercial ISS resupply cargo vehicle to replace the then-soon-to-be-retired Space Shuttle, through its Commercial Orbital Transportation Services (COTS) development program. The Dragon spacecraft was a part of SpaceX's proposal, submitted to NASA in March 2006. SpaceX's COTS proposal was issued as part of a team, which also included MD Robotics, the Canadian company that had built the ISS's Canadarm2.", "https://i.imgur.com/ef2kY1L.jpg", "ISS Resupply", 3 },
                    { 1, 1, "The Apollo program, also known as Project Apollo, was the third United States human spaceflight program carried out by the National Aeronautics and Space Administration (NASA), which succeeded in landing the first humans on the Moon from 1969 to 1972. First conceived during Dwight D. Eisenhower's administration as a three-person spacecraft to follow the one-person Project Mercury which put the first Americans in space, Apollo was later dedicated to the national goal set by President John F. Kennedy of \"landing a man on the Moon by the end of this decade and returning him safely to the Earth\" in an address to Congress on May 25, 1961. It was the third US human spaceflight program to fly, preceded by the two-person Project Gemini conceived in 1961 to extend spaceflight capability in support of Apollo.", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/00/Apollo_program.svg/800px-Apollo_program.svg.png", "Apollo", 10 },
                    { 3, 3, "Rosetta was a space probe built by the European Space Agency launched on 2 March 2004. Along with Philae, its lander module, Rosetta performed a detailed study of comet 67P/Churyumov–Gerasimenko (67P). During its journey to the comet, the spacecraft flew three times by Earth, by Mars, and the asteroids 21 Lutetia and 2867 Šteins. It was launched as the third cornerstone mission of the ESA's Horizon 2000 programme", "http://1.bp.blogspot.com/-dt7WFuKvwWk/VFv2aOa1-4I/AAAAAAAAjiA/IyF9vx99Lq0/s1600/600px-Logo_-_Sonde_Rosetta.svg.png", "Rosetta - Philae", 11 }
                });

            migrationBuilder.InsertData(
                table: "MissionNumbers",
                columns: new[] { "MissionNumberId", "Description", "MissionId", "MissionIterationNumber" },
                values: new object[,]
                {
                    { 2, "", 2, "1" },
                    { 4, "", 4, "1" },
                    { 1, "", 1, "1" },
                    { 3, "", 3, "1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MissionNumbers_MissionId",
                table: "MissionNumbers",
                column: "MissionId");

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
                name: "MissionNumbers");

            migrationBuilder.DropTable(
                name: "Missions");

            migrationBuilder.DropTable(
                name: "Agencies");

            migrationBuilder.DropTable(
                name: "StellarBodies");
        }
    }
}
