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
        public DbSet<AgencyStellarBody> AgencyStellarBodies { get; set; }

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
            modelBuilder.Entity<AgencyStellarBody>().HasData(
                new AgencyStellarBody()
                {
                    AgencyStellarBodyId = 1,
                    AgencyId = 1,
                    StellarBodyId = 1
                },
                new AgencyStellarBody()
                {
                    AgencyStellarBodyId = 2,
                    AgencyId = 2,
                    StellarBodyId = 2
                },
                new AgencyStellarBody()
                {
                    AgencyStellarBodyId = 3,
                    AgencyId = 3,
                    StellarBodyId = 3
                },
                new AgencyStellarBody()
                {
                    AgencyStellarBodyId = 4,
                    AgencyId = 4,
                    StellarBodyId = 4
                }
                );

            modelBuilder.Entity<StellarBody>().HasData(
                new StellarBody()
                {
                    StellarBodyId = 1,
                    Name = "Moon",
                    
                },
                new StellarBody()
                {
                    StellarBodyId = 2,
                    Name = "Venus",
                    
                },
                new StellarBody()
                {
                    StellarBodyId = 3,
                    Name = "Comet",
                    
                },
                new StellarBody()
                {
                    StellarBodyId = 4,
                    Name = "LEO",
                    
                }
                );

            modelBuilder.Entity<Mission>().HasData(
                new Mission()
                {
                    MissionId = 1,
                    Name = "Apollo",
                    AgencyId = 1
                },
                new Mission()
                {
                    MissionId = 2,
                    Name = "Venera",
                    AgencyId = 2
                },
                new Mission()
                {
                    MissionId = 3,
                    Name = "Philae",
                    AgencyId = 3
                },
                new Mission()
                {
                    MissionId = 4,
                    Name = "ISS Resupply",
                    AgencyId = 4
                }
                );



        }
    }
}
