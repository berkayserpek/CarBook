using CarBookApplication.Features.Mediator.Commands.FooterAddressComands;
using CarBookApplication.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.Mediator.Handlers.FooterAddresHandlers
{
    public class UpdateFooterAddressCommandHandler : IRequestHandler<UpdateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;

        public UpdateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            if (value != null)
            {
                value.Address = request.Address;
                value.PhoneNumber = request.PhoneNumber;    
                value.Description = request.Description;
                value.Email = request.Email;
                await _repository.UpdateAsync(value);
            }
        }
    }
}
