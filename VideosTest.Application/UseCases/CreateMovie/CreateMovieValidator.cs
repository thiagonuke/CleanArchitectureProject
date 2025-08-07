using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTest.Application.UseCases.CreateMovie
{
    public sealed class CreateMovieValidator : AbstractValidator<CreateMovieRequest>
    {
        public CreateMovieValidator()
        {
            RuleFor(x => x.Title).NotEmpty().MinimumLength(3).MaximumLength(100);
            RuleFor(x => x.Description).NotEmpty().MinimumLength(10).MaximumLength(500);
            RuleFor(x => x.DurationMinutes).NotEmpty();
            RuleFor(x => x.ReleasedDate).NotEmpty();
        }
    }
}
