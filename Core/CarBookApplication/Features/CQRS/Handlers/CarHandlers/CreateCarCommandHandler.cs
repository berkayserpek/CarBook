using CarBookApplication.Features.CQRS.Commands.BrandCommands;
using CarBookApplication.Features.CQRS.Commands.CarCommands;
using CarBookApplication.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                Luggage = command.Luggage,
                KM = command.KM,
                Fuel = command.Fuel,
                CoverImageURL = command.CoverImageURL,
                BrandID = command.BrandID,
                Model = command.Model,
                Seat = command.Seat,
                BigImageURL = command.BigImageURL,
                Transmission = command.Transmission
            });
        }
    }
}
