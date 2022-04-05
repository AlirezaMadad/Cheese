using Application.Commands;
using Application.Mapper;
using Application.Responses;
using Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.CommandHandlers
{

    public class CreateCheeseHandler : IRequestHandler<CreateCheeseCommand, CheeseResponse>
    {
        private readonly ICheeseRepository _cheeseRepository;

        public CreateCheeseHandler(ICheeseRepository cheeseRepository)
        {
            _cheeseRepository = cheeseRepository;
        }
        public async Task<CheeseResponse> Handle(CreateCheeseCommand request, CancellationToken cancellationToken)
        {
            var cheeseEntity = CheeseMapper.Mapper.Map<Core.Entities.Cheese>(request);
            if(cheeseEntity is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newCheese = await _cheeseRepository.AddAsync(cheeseEntity);
            var cheeseResponse = CheeseMapper.Mapper.Map<CheeseResponse>(newCheese);
            return cheeseResponse;
        }
    }
}
