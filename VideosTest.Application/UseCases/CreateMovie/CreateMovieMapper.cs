using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoTest.Domain.Entities;

namespace MovieTest.Application.UseCases.CreateMovie
{
    public sealed class CreateMovieMapper : Profile
    {
        public CreateMovieMapper() 
        {
            CreateMap<CreateMovieRequest, Movie>(); 
            CreateMap<Movie, CreateMovieResponse>(); 
        }  
    }
}
