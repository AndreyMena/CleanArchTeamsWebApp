using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using Domain.Core.Repositories;


namespace Infrastructure.Core
{
    public class ApplicationDbContext : DbContext, IUnitOfWork
    {
        public ApplicationDbContext(DbContextOptions options)
        : base(options)
        {
        }

        public async Task SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            await base.SaveChangesAsync(cancellationToken);
        }

    }
}
