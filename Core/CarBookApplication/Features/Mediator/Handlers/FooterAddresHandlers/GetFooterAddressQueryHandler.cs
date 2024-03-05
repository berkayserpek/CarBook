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
    public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQuery, List<GetFooterAddressQueryResult>>
    {
        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFooterAddressQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFooterAddressQueryResult
            {
                Address = x.Address,
                Description = x.Description,
                Email = x.Email,
                ID = x.ID,
                PhoneNumber = x.PhoneNumber
            }).ToList();
        }
    }
}
