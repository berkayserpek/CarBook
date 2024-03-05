using CarBookApplication.Features.CQRS.Queries.BannerQueries;
using CarBookApplication.Features.CQRS.Queries.BrandQueries;
using CarBookApplication.Features.CQRS.Results.BannerResults;
using CarBookApplication.Features.CQRS.Results.BrandResults;
using CarBookApplication.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandByIdQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.ID);
            return new GetBrandByIdQueryResult
            {
                ID = values.ID,
                Name = values.Name
            };
        }
    }
}
