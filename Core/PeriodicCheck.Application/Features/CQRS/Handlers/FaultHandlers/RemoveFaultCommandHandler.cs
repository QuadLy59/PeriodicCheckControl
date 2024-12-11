using PeriodicCheck.Application.Features.CQRS.Commands.FaultCommands;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handlers.FaultHandlers
{
    public class RemoveFaultCommandHandler
    {
        private readonly IRepository<Fault> _repository;

        public RemoveFaultCommandHandler(IRepository<Fault> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveFaultCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
