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
    public class CreateWarehouseCommandHandler
    {
        private readonly IRepository<Warehouse> _repository;

        public CreateWarehouseCommandHandler(IRepository<Warehouse> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateWarehouseCommand command)
        {
            await _repository.CreateAsync(new Warehouse
            {
                Ins_date = command.Ins_date,
                Ins_user = command.Ins_user,
                 Is_active = command.Is_active,
                 Warehouse_name = command.Warehouse_name,
                 
            });
        }
    }
}
