using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Teams;
using Application.Teams.Implementation;
using Application.Teams.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddTransient<ITeamService, TeamService>();
            services.AddTransient<IFootbalService, FootballService>();

            return services;
        }
    }
}
