using AutoMapper;
using MediatR;
using MovieTest.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoTest.Domain.Entities;
using VideoTest.Domain.Interfaces;

namespace MovieTest.Application.UseCases.CreateMovie
{
   public class CreateMovieHandler : 
        IRequestHandler<CreateMovieRequest, CreateMovieResponse>
   {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;

        public CreateMovieHandler(IUnitOfWork unitOfWork,IMovieRepository movieRepository, IMapper mapper) 
        { 
            _unitOfWork = unitOfWork;       
            _movieRepository = movieRepository;
            _mapper = mapper;

        }


        public async Task<CreateMovieResponse> Handle(CreateMovieRequest request, CancellationToken cancellationToken) 
        {
            _movieRepository.Create(_mapper.Map<Movie>(request));

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<CreateMovieResponse>(request);
        
        }

   }
}
