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
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        public MovieRepository(AppDbContext appDbContext) : base(appDbContext)
        { }

        public async Task<Movie> GetById(int id, CancellationToken cancellationToken) => await _appDbContext.Movies.FirstAsync(t => t.IdFilm == id, cancellationToken);
    }   
}
