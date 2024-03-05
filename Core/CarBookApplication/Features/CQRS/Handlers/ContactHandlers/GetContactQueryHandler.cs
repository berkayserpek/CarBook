using CarBookApplication.Features.CQRS.Commands.ContactCommands;
using CarBookApplication.Features.CQRS.Results.ContactResults;
using CarBookApplication.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactQueryHandler
    {
        private readonly IRepository<Contact> _repository;

        public GetContactQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetContactQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetContactQueryResult
            {
                ID = x.ID,
                Name = x.Name,
                SendDate = x.SendDate,
                Subject = x.Subject,
                Email = x.Email,
                Message = x.Message
            }).ToList();
        }
    }
}
