﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpaceProgramMissionTracker;

namespace SpaceProgramMissionTracker.Migrations
{
    [DbContext(typeof(SiteContext))]
    partial class SiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SpaceProgramMissionTracker.Model.Agency", b =>
                {
                    b.Property<int>("AgencyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("AgencyId");

                    b.ToTable("Agencies");

                    b.HasData(
                        new { AgencyId = 1, Name = "NASA" },
                        new { AgencyId = 2, Name = "Roscosmos" },
                        new { AgencyId = 3, Name = "ESA" },
                        new { AgencyId = 4, Name = "SpaceX" }
                    );
                });

            modelBuilder.Entity("SpaceProgramMissionTracker.Model.Mission", b =>
                {
                    b.Property<int>("MissionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgencyId");

                    b.Property<string>("Name");

                    b.Property<int>("StellarBodyId");

                    b.HasKey("MissionId");

                    b.HasIndex("AgencyId");

                    b.HasIndex("StellarBodyId");

                    b.ToTable("Missions");

                    b.HasData(
                        new { MissionId = 1, AgencyId = 1, Name = "Apollo", StellarBodyId = 1 },
                        new { MissionId = 2, AgencyId = 2, Name = "Venera", StellarBodyId = 2 },
                        new { MissionId = 3, AgencyId = 3, Name = "Philae", StellarBodyId = 3 },
                        new { MissionId = 4, AgencyId = 4, Name = "ISS Resupply", StellarBodyId = 4 }
                    );
                });

            modelBuilder.Entity("SpaceProgramMissionTracker.Model.MissionNumber", b =>
                {
                    b.Property<int>("MissionNumberId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MissionId");

                    b.Property<string>("MissionIterationName");

                    b.HasKey("MissionNumberId");

                    b.HasIndex("MissionId");

                    b.ToTable("MissionNumbers");

                    b.HasData(
                        new { MissionNumberId = 1, MissionId = 1, MissionIterationName = "1" },
                        new { MissionNumberId = 2, MissionId = 2, MissionIterationName = "1" },
                        new { MissionNumberId = 3, MissionId = 3, MissionIterationName = "1" },
                        new { MissionNumberId = 4, MissionId = 4, MissionIterationName = "1" }
                    );
                });

            modelBuilder.Entity("SpaceProgramMissionTracker.Model.StellarBody", b =>
                {
                    b.Property<int>("StellarBodyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("StellarBodyId");

                    b.ToTable("StellarBodies");

                    b.HasData(
                        new { StellarBodyId = 1, Name = "Moon" },
                        new { StellarBodyId = 2, Name = "Venus" },
                        new { StellarBodyId = 3, Name = "Comet" },
                        new { StellarBodyId = 4, Name = "LEO" }
                    );
                });

            modelBuilder.Entity("SpaceProgramMissionTracker.Model.Mission", b =>
                {
                    b.HasOne("SpaceProgramMissionTracker.Model.Agency")
                        .WithMany("Missions")
                        .HasForeignKey("AgencyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SpaceProgramMissionTracker.Model.StellarBody")
                        .WithMany("Missions")
                        .HasForeignKey("StellarBodyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SpaceProgramMissionTracker.Model.MissionNumber", b =>
                {
                    b.HasOne("SpaceProgramMissionTracker.Model.Mission")
                        .WithMany("MissionNumbers")
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
