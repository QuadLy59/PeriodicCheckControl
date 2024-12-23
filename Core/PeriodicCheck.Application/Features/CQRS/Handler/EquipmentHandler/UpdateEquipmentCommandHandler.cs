using PeriodicCheck.Application.Features.CQRS.Command.EquipmentCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace PeriodicCheck.Application.Features.CQRS.Handler.EquipmentHandler
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
            var values = await _repository.GetByIdAsync(command.EquipmentId);
            values.Equipment_Name = command.Equipment_Name;
            values.Serial_No = command.Serial_No;
            values.Company = command.Company;
            values.WarehouseId = command.WarehouseId;
            values.Responsible = command.Responsible;
            values.Responsible_Communication = command.Responsible_Communication;
            values.Shift_Turn = command.Shift_Turn;
            values.CategoryId = command.CategoryId;
            values.CareId = command.CareId;
            values.StockId = command.StockId;
            values.FaultId = command.FaultId;
            values.Updated_user = command.Updated_user;
            values.Updated_date = command.Updated_date;
            values.Is_active = command.Is_active;
            await _repository.UpdateAsync(values);

        }
    }
}
