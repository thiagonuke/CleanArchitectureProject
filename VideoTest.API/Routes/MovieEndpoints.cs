using MediatR;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using MovieTest.Application;
using MovieTest.Application.UseCases.CreateMovie;
using Swashbuckle.AspNetCore.Annotations;

namespace MovieTest.API.Routes
{
    [ApiController]
    public static class MovieEndpoints
    {
        public static void MapMovieEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapPost("/v1/CreateMovie", async (CreateMovieRequest command, ISender mediator) => Results.Ok(await mediator.Send(command)))
                .WithName("CreateMovie")
                .WithTags("Movies")
                .WithSummary("Insere informações sobre um novo filme na base de dados")
                .WithDescription("Recebe os dados de um filme e o registra no sistema.")
                .Produces<Guid>(StatusCodes.Status201Created)
                .Produces(StatusCodes.Status400BadRequest)
                .Produces(StatusCodes.Status500InternalServerError);
        }
    }

}
