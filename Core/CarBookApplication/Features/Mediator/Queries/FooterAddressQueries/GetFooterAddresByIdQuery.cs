using CarBookApplication.Features.Mediator.Results.FeatureResults;
using CarBookApplication.Features.Mediator.Results.FooterAddressResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.Mediator.Queries.FooterAddressQueries
{
    public class GetFooterAddresByIdQuery : IRequest<GetFooterAddressByIdQueryResult>
    {
        public int ID { get; set; }

        public GetFooterAddresByIdQuery(int id)
        {
            ID = id;
        }
    }
}
