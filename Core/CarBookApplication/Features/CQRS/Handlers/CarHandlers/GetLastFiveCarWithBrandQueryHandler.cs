using CarBookApplication.Features.CQRS.Results.CarResults;
using CarBookApplication.Interfaces;
using CarBookApplication.Interfaces.CarInterfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.CQRS.Handlers.CarHandlers
{
    public class GetLastFiveCarWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetLastFiveCarWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }
        public List<GetLastFiveCarWithBrandQueryResult> Handle()
        {
            var values = _repository.GetLastFiveCarWithBrand();
            return values.Select(x => new GetLastFiveCarWithBrandQueryResult
            {
                BrandName = x.Brand.Name,
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
