using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Teams.Repositories;
using Infrastructure.Core;
using Infrastructure.Teams.Context;
using Infrastructure.Teams.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<TeamDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<ITeamRepository, TeamRepository>();
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IFootballTeamRepository, FootballTeamRepository>();

            return services;
        }
    }
}
