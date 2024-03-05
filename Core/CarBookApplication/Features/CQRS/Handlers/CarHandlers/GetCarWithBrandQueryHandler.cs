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
    public class GetCarWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetCarWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }
        public List<GetCarWithBrandQueryResult> Handle()
        {
            var values = _repository.GetCarListWithBrand();
            return values.Select(x => new GetCarWithBrandQueryResult
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
