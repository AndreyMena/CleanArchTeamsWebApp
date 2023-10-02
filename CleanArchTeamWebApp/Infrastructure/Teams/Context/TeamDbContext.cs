using Domain.Teams.Entities;
using Infrastructure.Core;
using Infrastructure.Teams.EntityMappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Teams.Context
{
    public class TeamDbContext : ApplicationDbContext
    {
        public TeamDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Team> Teams { get; set; } = null!;

        public DbSet<FootballTeam> FootballTeams { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TeamMap());
            modelBuilder.ApplyConfiguration(new FootbalTeamMap());

        }
    }
}
