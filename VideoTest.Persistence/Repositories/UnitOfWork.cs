using MovieTest.Domain.Interfaces;
using MovieTest.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTest.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;

        public UnitOfWork(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }

        public async Task Commit(CancellationToken cancellationToken) => await _appDbContext.SaveChangesAsync(cancellationToken);
    }
}
