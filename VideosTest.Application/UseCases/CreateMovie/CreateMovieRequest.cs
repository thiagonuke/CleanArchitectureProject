using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTest.Application.UseCases.CreateMovie
{
    public sealed record CreateMovieRequest(string Title, string Description, int DurationMinutes, DateTime ReleasedDate)
        :IRequest<CreateMovieResponse>
    {
    }
}
