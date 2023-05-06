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
    public class ColorsConfigurations : IEntityTypeConfiguration<Colors>
    {
        public void Configure(EntityTypeBuilder<Colors> builder)
        {
            builder
                .HasMany<Teams>(collection => collection.Home_teams)
                .WithOne(entity => entity.Home_colors)
                .HasForeignKey(result => result.Home_colors_ID)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany<Teams>(collection => collection.Away_teams)
                .WithOne(entity => entity.Away_colors)
                .HasForeignKey(result => result.Away_colors_ID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
