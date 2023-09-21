using Domain.Teams.Entities;
using Domain.Teams.Repositories;
using Infrastructure.Teams.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Core.Repositories;

namespace Infrastructure.Teams.Repositories
{
    internal class TeamRepository : ITeamRepository
    {
        protected readonly TeamDbContext _dbContext;

        public IUnitOfWork UnitOfWork => _dbContext;

        public TeamRepository(TeamDbContext unitOfWork)
        {
            _dbContext = unitOfWork;
        }
        public async Task<IEnumerable<Team>> GetAllAsync()
        {
            return await _dbContext.Teams.ToListAsync();
        }


        public async Task<Team?> GetByIdAsync(int id)
        {
            return await _dbContext.Teams.FindAsync(id);
        }

        public async Task SaveAsync(Team team)
        {
            _dbContext.Update(team);
            await _dbContext.SaveEntitiesAsync();
        }

        public async Task AddTeam(Team team)
        {
            _dbContext.Add(team);
            await _dbContext.SaveEntitiesAsync();
        }

        public async Task DeleteTeam(Team team)
        {
            _dbContext.Remove(team);
            await _dbContext.SaveEntitiesAsync();
        }
    }
}
