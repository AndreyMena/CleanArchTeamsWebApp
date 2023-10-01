using Domain.Teams.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Teams.EntityMappings
{
    public class FootbalTeamMap : IEntityTypeConfiguration<FootballTeam>
    {
        public void Configure(EntityTypeBuilder<FootballTeam> builder)
        {
            builder.ToTable("FootballTeam");

            builder.Property(r => r.StadiumName);
        }
    }
}
