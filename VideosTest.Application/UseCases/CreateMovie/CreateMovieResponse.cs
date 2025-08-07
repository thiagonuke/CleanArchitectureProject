using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTest.Application.UseCases.CreateMovie
{
     public sealed record CreateMovieResponse
     {
        public Guid? id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int DurationMinutes { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}
