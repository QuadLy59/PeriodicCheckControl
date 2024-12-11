using PeriodicCheck.Application.Features.CQRS.Commands.PeriodicActivityStatusCommands;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handlers.PeriodicActivityStatusHandlers
{
    public class RemovePeriodicActivityStatusCommandHandler
    {
        private readonly IRepository<PeriodicActivityStatus> _repository;

        public RemovePeriodicActivityStatusCommandHandler(IRepository<PeriodicActivityStatus> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemovePeriodicActivityStatusCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
