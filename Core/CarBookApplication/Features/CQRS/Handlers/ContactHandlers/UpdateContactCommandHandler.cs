﻿using CarBookApplication.Features.CQRS.Commands.BrandCommands;
using CarBookApplication.Features.CQRS.Commands.ContactCommands;
using CarBookApplication.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.CQRS.Handlers.ContactHandlers
{
    public class UpdateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateContactCommand command)
        {
            var value = await _repository.GetByIdAsync(command.ID);
            if (value != null)
            {
                value.Name = command.Name;
                value.SendDate = command.SendDate;
                value.Email = command.Email;
                value.Message = command.Message;
                value.Subject = command.Subject;
                await _repository.UpdateAsync(value);
            }
        }
    }
}
