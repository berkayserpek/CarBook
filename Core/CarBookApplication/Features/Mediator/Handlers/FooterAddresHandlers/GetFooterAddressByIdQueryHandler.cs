using CarBookApplication.Features.Mediator.Queries.FooterAddressQueries;
using CarBookApplication.Features.Mediator.Results.FooterAddressResult;
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
    public class GetFooterAddressByIdQueryHandler : IRequestHandler<GetFooterAddresByIdQuery, GetFooterAddressByIdQueryResult>
    {
        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressByIdQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<GetFooterAddressByIdQueryResult> Handle(GetFooterAddresByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            return new GetFooterAddressByIdQueryResult
            {
                ID = value.ID,
                Address = value.Address,
                Description = value.Description,
                Email = value.Email,
                PhoneNumber = value.PhoneNumber,
            };
        }
    }
}
