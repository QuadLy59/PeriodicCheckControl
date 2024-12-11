using PeriodicCheck.Application.Features.CQRS.Commands.EquipmentCommands;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handlers.EquipmentHandlers
{
    public class RemoveEquipmentCommandHandler
    {
        private readonly IRepository<Equipment> _repository;

        public RemoveEquipmentCommandHandler(IRepository<Equipment> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveEquipmentCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
