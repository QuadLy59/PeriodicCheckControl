using PeriodicCheck.Application.Features.CQRS.Commands.WarehouseCommands;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handlers.WarehouseHandlers
{
    public class RemoveWarehouseCommandHandler
    {
        private readonly IRepository<Warehouse> _repository;

        public RemoveWarehouseCommandHandler(IRepository<Warehouse> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveWarehouseCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
