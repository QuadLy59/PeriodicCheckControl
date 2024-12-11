using PeriodicCheck.Application.Features.CQRS.Commands.CareCommands;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handlers.CareHandlers
{
    public class RemoveCareCommandHandler
    {
        private readonly IRepository<Care> _repository;

        public RemoveCareCommandHandler(IRepository<Care> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveCareCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
