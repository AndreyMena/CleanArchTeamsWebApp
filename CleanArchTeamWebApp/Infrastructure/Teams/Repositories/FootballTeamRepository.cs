using Domain.Teams.Entities;
using Domain.Teams.Repositories;
using Infrastructure.Teams.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Teams.Repositories
{
    internal class FootballTeamRepository : TeamRepository, IFootballTeamRepository
    {
        public FootballTeamRepository(TeamDbContext unitOfWork) : base(unitOfWork)
        {
        }

        public string GetStadiumName(int id)
        {
            return _dbContext.FootballTeams.Where(f => f.Id == id).First().StadiumName;
        }
    }
}
