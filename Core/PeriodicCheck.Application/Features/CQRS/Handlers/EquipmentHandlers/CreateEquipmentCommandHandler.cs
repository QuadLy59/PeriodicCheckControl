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
    public class CreateEquipmentCommandHandler
    {
        private readonly IRepository<Equipment> _repository;

        public CreateEquipmentCommandHandler(IRepository<Equipment> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateEquipmentCommand command)
        {
            await _repository.CreateAsync(new Equipment
            {
                Equipment_name=command.Equipment_name,
                Serial_no=command.Serial_no,
                Company=command.Company,
                Warehouse_id=command.Warehouse_id,
                Responsible=command.Responsible,
                Communication=command.Communication,
                Category_id=command.Category_id,
                Ins_user=command.Ins_user,
                Ins_date=command.Ins_date,
                Is_active=command.Is_active,
            });
        }
    }
}
