using PeriodicCheck.Application.Features.CQRS.Command.FaultNameCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.FaultNameHandler
{
    public class RemoveFaultNameCommandHandler
    {
        private readonly IRepository<FaultName> _repository;

        public RemoveFaultNameCommandHandler(IRepository<FaultName> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveFaultNameCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
