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

        public Task<IFootballTeamRepository?> GetStadiumName(int id)
        {
            throw new NotImplementedException();
        }
    }
}
