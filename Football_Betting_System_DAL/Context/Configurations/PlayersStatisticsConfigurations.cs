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
    public class PlayersStatisticsConfigurations : IEntityTypeConfiguration<PlayersStatistics>
    {
        public void Configure(EntityTypeBuilder<PlayersStatistics> builder)
        {
            builder.HasKey(nameof(PlayersStatistics.Playes_ID), nameof(PlayersStatistics.Games_ID));

            builder
                .HasOne<Players>(entity => entity.Players)
                .WithMany(collection => collection.PlayersStatistics)
                .HasForeignKey(result => result.Playes_ID);

            builder
                .HasOne<Games>(entity => entity.Games)
                .WithMany(collection => collection.PlayersStatistics)
                .HasForeignKey(result => result.Playes_ID);
        }
    }
}
