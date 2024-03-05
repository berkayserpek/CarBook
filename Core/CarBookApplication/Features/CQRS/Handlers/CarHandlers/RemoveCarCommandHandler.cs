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
    public class RemoveCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public RemoveCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveCarCommand command)
        {
            var value = await _repository.GetByIdAsync(command.ID);
            if (value != null)
            {
                await _repository.DeleteAsync(value);
            }
        }
    }
}
