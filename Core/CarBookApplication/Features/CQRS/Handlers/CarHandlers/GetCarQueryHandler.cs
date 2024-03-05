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
    public class GetCarQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCarQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCarQueryResult
            {
                ID = x.ID,
                BigImageURL = x.BigImageURL,
                BrandID = x.BrandID,
                CoverImageURL = x.CoverImageURL,
                Fuel = x.Fuel,
                KM = x.KM,
                Luggage = x.Luggage,
                Model = x.Model,
                Seat = x.Seat,
                Transmission = x.Transmission
            }).ToList();
        }
    }
}
