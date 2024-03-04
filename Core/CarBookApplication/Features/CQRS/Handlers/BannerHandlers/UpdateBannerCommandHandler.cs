using CarBookApplication.Features.CQRS.Commands.BannerCommands;
using CarBookApplication.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateBannerCommand command)
        {
            var value = await _repository.GetByIdAsync(command.ID);
            if (value != null)
            {
                value.VideURL = command.VideURL;
                value.VideoDescription = command.VideoDescription;
                value.Title = command.Title;
                value.Description = command.Description;
                await _repository.UpdateAsync(value);

            }
        }
    }
}
