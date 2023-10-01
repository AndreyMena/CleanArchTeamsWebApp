using Domain.Core.Repositories;
using Domain.Teams.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Teams.Repositories
{
    public interface IFootballTeamRepository : IRepository<FootballTeam>, ITeamRepository
    {
        Task<IFootballTeamRepository?> GetStadiumName(int id);
    }
}
