using Application.Queries;
using Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.QueryHandlers
{
    public class GetAllCheeseHandler : IRequestHandler<GetAllCheeseQuery, List<Core.Entities.Cheese>>
    {
        private readonly ICheeseRepository _cheeseRepository;

        public GetAllCheeseHandler(ICheeseRepository cheeseRepository)
        {
            _cheeseRepository = cheeseRepository;
        }
        public async Task<List<Core.Entities.Cheese>> Handle(GetAllCheeseQuery request, CancellationToken cancellationToken)
        {
            return (List<Core.Entities.Cheese>)await _cheeseRepository.GetAllCheesesAsync();
        }
    }
}
