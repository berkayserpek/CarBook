using CarBookApplication.Features.CQRS.Queries.BrandQueries;
using CarBookApplication.Features.CQRS.Queries.CategoryQueries;
using CarBookApplication.Features.CQRS.Results.BrandResults;
using CarBookApplication.Features.CQRS.Results.CategoryResult;
using CarBookApplication.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryByIdQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.ID);
            return new GetCategoryByIdQueryResult
            {
                ID = values.ID,
                Name = values.Name
            };
        }
    }
}
