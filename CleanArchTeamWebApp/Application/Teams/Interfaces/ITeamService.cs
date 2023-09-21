using Domain.Teams.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Teams.Interfaces
{
    public interface ITeamService
    {
        Task<IEnumerable<Team>> GetTeamsAsync();
        Task<Team?> GetTeamByIdAsync(int id);
        Task AddTeamAsync(Team team);
        Task DeleteTeamAsync(Team team);
    }
}
