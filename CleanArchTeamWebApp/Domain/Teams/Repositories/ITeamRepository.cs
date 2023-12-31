﻿using Domain.Teams.Entities;
using Domain.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Teams.Repositories
{
    public interface ITeamRepository : IRepository<Team>
    {
        Task<IEnumerable<Team>> GetAllAsync();
        Task<Team?> GetByIdAsync(int id);
        Task SaveAsync(Team team);
        Task AddTeam(Team team);
        Task DeleteTeam(Team team);
    }
}
