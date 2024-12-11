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
    public class UpdateWarehouseCommandHandler
    {
        private readonly IRepository<Warehouse> _repository;

        public UpdateWarehouseCommandHandler(IRepository<Warehouse> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateWarehouseCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Warehouse_id);
            values.Warehouse_name = command.Warehouse_name;
            values.Updated_date = command.Updated_date;
            values.Updated_user = command.Updated_user;
            values.Is_active = command.Is_active;
            await _repository.UpdateAsync(values);
        }
    }
}
