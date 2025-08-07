using Microsoft.AspNetCore.Builder;
using MovieTest.API.Routes;
using MovieTest.Application;
using MovieTest.Application.Services;
using MovieTest.Persistence;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.ConfigurePersistenceApp(builder.Configuration);
builder.Services.ConfigureAplicationApp();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapMovieEndpoints();
app.UseSwagger();
app.UseSwaggerUI();

app.Run();
