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
    public class UpdateEquipmentCommandHandler
    {
        private readonly IRepository<Equipment> _repository;

        public UpdateEquipmentCommandHandler(IRepository<Equipment> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateEquipmentCommand command)
        {
            var values =await _repository.GetByIdAsync(command.Equipment_id);
            values.Equipment_name = command.Equipment_name;
            values.Serial_no = command.Serial_no;
            values.Company = command.Company;
            values.Warehouse_id = command.Warehouse_id;
            values.Responsible = command.Responsible;
            values.Communication = command.Communication;
            values.Category_id = command.Category_id;
            values.Updated_user = command.Updated_user;
            values.Updated_date = command.Updated_date;
            values.Is_active = command.Is_active;
            await _repository.UpdateAsync(values);
        }
    }
}
