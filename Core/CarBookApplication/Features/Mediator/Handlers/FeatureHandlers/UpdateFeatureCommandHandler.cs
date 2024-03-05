using CarBookApplication.Features.Mediator.Commands.FeatureCommands;
using CarBookApplication.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.Mediator.Handlers.FeatureHandlers
{
    public class UpdateFeatureCommandHandler : IRequestHandler<UpdateFeatureCommand>
    {
        private readonly IRepository<UpdateFeatureCommand> _repository;

        public UpdateFeatureCommandHandler(IRepository<UpdateFeatureCommand> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFeatureCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            if (value != null)
            {
                value.Name = request.Name;
                await _repository.UpdateAsync(value);
            }
        }
    }
}
