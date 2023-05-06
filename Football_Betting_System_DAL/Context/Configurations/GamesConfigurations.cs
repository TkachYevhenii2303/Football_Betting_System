﻿using Football_Betting_System_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Betting_System_DAL.Context.Configurations
{
    public class GamesConfigurations : IEntityTypeConfiguration<Games>
    {
        public void Configure(EntityTypeBuilder<Games> builder)
        {
            builder
                .HasMany<Bets>(collection => collection.Bets)
                .WithOne(entity => entity.Games)
                .HasForeignKey(result => result.Games_ID);
        }
    }
}
