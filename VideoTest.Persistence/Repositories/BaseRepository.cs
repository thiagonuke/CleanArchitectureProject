using Microsoft.EntityFrameworkCore;
using MovieTest.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoTest.Domain.Entities;
using VideoTest.Domain.Interfaces;

namespace MovieTest.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext _appDbContext;

        public BaseRepository(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;   
        
        }
        public void Create(T entity)
        {
            entity.DateCreated = DateTimeOffset.UtcNow;
            _appDbContext.Add(entity);  
        }

        public void Update(T entity)
        {
            entity.DateUpdated = DateTimeOffset.UtcNow;
            _appDbContext.Add(entity);
        }

        public void Delete(T entity)
        {
            entity.DateDeleted = DateTimeOffset.UtcNow; 
            _appDbContext.Add(entity);
        }

        public async Task<T> Get(Guid id, CancellationToken cancellationToken) => await _appDbContext.Set<T>().FirstAsync(t => t.Id == id, cancellationToken);
            
        public async Task<List<T>> GetAll(CancellationToken cancellationToken) => await _appDbContext.Set<T>().ToListAsync(cancellationToken);


    }
}
