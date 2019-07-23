using SpaceProgramMissionTracker.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceProgramMissionTracker
{
    public class SiteContext : DbContext
    {
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<StellarBody> StellarBodies { get; set; }
        public DbSet<Mission> Missions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=SPMT;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agency>().HasData(
                new Agency()
                {
                    AgencyId = 1,
                    Name = "NASA",
                },
                new Agency()
                {
                    AgencyId = 2,
                    Name = "Roscosmos",
                },
                new Agency()
                {
                    AgencyId = 3,
                    Name = "ESA",
                },
                new Agency()
                {
                    AgencyId = 4,
                    Name = "SpaceX",
                }
                );

            modelBuilder.Entity<StellarBody>().HasData(
                new StellarBody()
                {
                    StellarBodyId = 1,
                    Name = "Moon",
                    AgencyId = 1
                },
                new StellarBody()
                {
                    StellarBodyId = 2,
                    Name = "Venus",
                    AgencyId = 2
                },
                new StellarBody()
                {
                    StellarBodyId = 3,
                    Name = "Comet",
                    AgencyId = 3
                },
                new StellarBody()
                {
                    StellarBodyId = 4,
                    Name = "LEO",
                    AgencyId = 4
                }
                );

            modelBuilder.Entity<Mission>().HasData(
                new Mission()
                {
                    MissionId = 1,
                    Name = "Apollo",
                    StellarBodyId = 1
                },
                new Mission()
                {
                    MissionId = 2,
                    Name = "Venera",
                    StellarBodyId = 2
                },
                new Mission()
                {
                    MissionId = 3,
                    Name = "Philae",
                    StellarBodyId = 3
                },
                new Mission()
                {
                    MissionId = 4,
                    Name = "ISS Resupply",
                    StellarBodyId = 4
                }
                );



        }
    }
}
