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
    public class PlayersConfigurations : IEntityTypeConfiguration<Players>
    {
        public void Configure(EntityTypeBuilder<Players> builder)
        {
            builder
                .HasMany(collection => collection.PlayersStatistics)
                .WithOne(entity => entity.Players)
                .HasForeignKey(result => result.Playes_ID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
