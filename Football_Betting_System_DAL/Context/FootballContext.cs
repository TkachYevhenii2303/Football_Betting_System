using Football_Betting_System_DAL.Context.Configurations;
using Football_Betting_System_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Betting_System_DAL.Context
{
    public class FootballContext : DbContext
    {
        public FootballContext(DbContextOptions<FootballContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlayersConfigurations());
            modelBuilder.ApplyConfiguration(new ColorsConfigurations());
            modelBuilder.ApplyConfiguration(new GamesConfigurations());
            modelBuilder.ApplyConfiguration(new PlayersStatisticsConfigurations());
            modelBuilder.ApplyConfiguration(new TeamsConfigurations());
            modelBuilder.ApplyConfiguration(new UsersConfigurations());
        }
    }
}
