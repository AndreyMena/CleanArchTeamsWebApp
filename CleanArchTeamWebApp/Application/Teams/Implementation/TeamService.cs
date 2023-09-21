using Application.Teams.Interfaces;
using Domain.Teams.Entities;
using Domain.Teams.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Teams.Implementation
{
    internal class TeamService : ITeamService
    {
        private readonly ITeamRepository _teamRepository;

        public TeamService(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public async Task<IEnumerable<Team>> GetTeamsAsync()
        {
            return await _teamRepository.GetAllAsync();
        }
    }
}
