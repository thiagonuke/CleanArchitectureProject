using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoTest.Domain.Entities
{
    public class Movie : BaseEntity
    {
        public int? IdFilm { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int DurationMinutes { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
