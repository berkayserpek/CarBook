using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.Mediator.Commands.FooterAddressComands
{
    public class RemoveFooterAddressCommand : IRequest
    {
        public int ID { get; set; }

        public RemoveFooterAddressCommand(int id)
        {
            ID = id;
        }
    }
}
