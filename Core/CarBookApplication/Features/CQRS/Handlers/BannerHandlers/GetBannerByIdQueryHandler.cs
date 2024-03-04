using CarBookApplication.Features.CQRS.Queries.BannerQueries;
using CarBookApplication.Features.CQRS.Results.AboutResults;
using CarBookApplication.Features.CQRS.Results.BannerResults;
using CarBookApplication.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerByIdQueryHandler
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerByIdQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.ID);
            return new GetBannerByIdQueryResult
            {
                ID = values.ID,
                Description = values.Description,
                Title = values.Title,
                VideoDescription = values.VideoDescription,
                VideURL = values.VideURL,
            };
        }
    }
}
