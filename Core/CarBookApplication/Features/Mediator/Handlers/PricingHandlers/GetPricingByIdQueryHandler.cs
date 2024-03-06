using CarBookApplication.Features.Mediator.Queries.LocationQueries;
using CarBookApplication.Features.Mediator.Queries.PricingQueries;
using CarBookApplication.Features.Mediator.Results.LocationResults;
using CarBookApplication.Features.Mediator.Results.PricingResults;
using CarBookApplication.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.Mediator.Handlers.PricingHandlers
{
    public class GetPricingByIdQueryHandler : IRequestHandler<GetPricingByIdQuery, GetPricingByIdQueryResult>
    {
        private readonly IRepository<Pricing> _repository;

        public GetPricingByIdQueryHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task<GetPricingByIdQueryResult> Handle(GetPricingByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            if(value != null)
            {
                return new GetPricingByIdQueryResult
                {
                    Name = value.Name,
                    ID = value.ID,
                };
            }
            return new GetPricingByIdQueryResult();
        }
    }
}
