using Application.Teams.Interfaces;
using Domain.Teams.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Teams.Implementation
{
    internal class FootballService : IFootbalService
    {
        private readonly IFootballTeamRepository _fotballTeamRepository;

        public FootballService(IFootballTeamRepository fotballTeamRepository)
        {
            _fotballTeamRepository = fotballTeamRepository;
        }

        public string GetStadiumName(int id)
        {
            return _fotballTeamRepository.GetStadiumName(id);
        }
    }
}
