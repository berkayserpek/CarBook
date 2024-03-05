using CarBookApplication.Features.CQRS.Results.BrandResults;
using CarBookApplication.Features.Mediator.Queries.FeatureQueries;
using CarBookApplication.Features.Mediator.Results.FeatureResults;
using CarBookApplication.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.Mediator.Handlers.FeatureHandlers
{
    public class GetFeatureByIdQueryHandler : IRequestHandler<GetFeatureByIdQuery, GetFeatureByIdQueryResult>
    {
        private readonly IRepository<Feature> _repository;

        public GetFeatureByIdQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task<GetFeatureByIdQueryResult> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ID);
            return new GetFeatureByIdQueryResult
            {
                ID = values.ID,
                Name = values.Name
            };
        }
    }
}
