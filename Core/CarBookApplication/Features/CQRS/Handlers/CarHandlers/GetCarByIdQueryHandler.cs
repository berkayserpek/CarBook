using CarBookApplication.Features.CQRS.Queries.BrandQueries;
using CarBookApplication.Features.CQRS.Queries.CarQueries;
using CarBookApplication.Features.CQRS.Results.BrandResults;
using CarBookApplication.Features.CQRS.Results.CarResults;
using CarBookApplication.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.ID);
            return new GetCarByIdQueryResult
            {
                ID = values.ID,
                BigImageURL = values.BigImageURL,
                Transmission = values.Transmission,
                Seat = values.Seat,
                Model = values.Model,
                BrandID = values.BrandID,
                CoverImageURL = values.CoverImageURL,
                Fuel = values.Fuel,
                KM = values.KM,
                Luggage = values.Luggage
            };
        }
    }
}
