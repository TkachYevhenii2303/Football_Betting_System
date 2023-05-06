using Football_Betting_System_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Betting_System_DAL.Context.Configurations
{
    public class TeamsConfigurations : IEntityTypeConfiguration<Teams>
    {
        public void Configure(EntityTypeBuilder<Teams> builder)
        {
            builder
                .HasMany<Games>(collection => collection.Home_games)
                .WithOne(entity => entity.Home_teams)
                .HasForeignKey(result => result.Home_teams_ID);

            builder
                .HasMany<Games>(collection => collection.Away_games)
                .WithOne(entity => entity.Away_teams)
                .HasForeignKey(result => result.Away_teams_ID);
        }
    }
}
