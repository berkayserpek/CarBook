﻿using CarBookApplication.Features.CQRS.Commands.BannerCommands;
using CarBookApplication.Features.CQRS.Commands.BrandCommands;
using CarBookApplication.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.CQRS.Handlers.BrandHandlers
{
    public class RemoveBrandCommandHandler
    {
        private readonly IRepository<Brand> _repository;

        public RemoveBrandCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveBrandCommand command)
        {
            var value = await _repository.GetByIdAsync(command.ID);
            if (value != null)
            {
                await _repository.DeleteAsync(value);
            }
        }
    }
}
