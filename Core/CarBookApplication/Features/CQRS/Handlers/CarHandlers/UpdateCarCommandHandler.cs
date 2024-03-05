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
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCarCommand command)
        {
            var value = await _repository.GetByIdAsync(command.ID);
            if (value != null)
            {
                value.Fuel = command.Fuel;
                value.Transmission = command.Transmission;
                value.BigImageURL = command.BigImageURL;
                value.BrandID = command.BrandID;
                value.CoverImageURL = command.CoverImageURL;
                value.KM = command.KM;
                value.Luggage = command.Luggage;
                value.Seat = command.Seat;
                value.Model = command.Model;
                await _repository.UpdateAsync(value);
            }
        }
    }
}
