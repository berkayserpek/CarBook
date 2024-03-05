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
    public class CreateFooterAddresCommandHandler : IRequestHandler<CreateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;

        public CreateFooterAddresCommandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new FooterAddress
            {
                Address = request.Address,
                Description = request.Description,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
            });
        }
    }
}
