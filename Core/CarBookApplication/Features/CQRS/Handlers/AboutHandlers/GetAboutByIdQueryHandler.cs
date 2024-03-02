using CarBookApplication.Features.CQRS.Queries.AboutQueries;
using CarBookApplication.Features.CQRS.Results.AboutResults;
using CarBookApplication.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutByIdQueryHandler
    {
        private readonly IRepository<About> _repository;

        public GetAboutByIdQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery getAboutByIdQuery)
        {
            var values = await _repository.GetByIdAsync(getAboutByIdQuery.ID);
            return new GetAboutByIdQueryResult
            {
                ID = getAboutByIdQuery.ID,
                Description = values.Description,
                ImageURL = values.ImageURL,
                Title = values.Title,
            };
        }
    }
}
