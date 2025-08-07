using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoTest.Domain.Entities;

namespace VideoTest.Domain.Interfaces
{
    public interface IMovieRepository : IBaseRepository<Movie>
    {

        Task<Movie> GetById(int id, CancellationToken cancellationToken);

    }
}
