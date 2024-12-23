using PeriodicCheck.Application.Features.CQRS.Command.EquipmentCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.EquipmentHandler
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
                Equipment_Name=command.Equipment_Name,
                Serial_No=command.Serial_No,
                Company=command.Company,
                WarehouseId=command.WarehouseId,
                Responsible=command.Responsible,
                Responsible_Communication=command.Responsible_Communication,
                Shift_Turn=command.Shift_Turn,
                CategoryId=command.CategoryId,
                CareId = command.CareId,
                StockId = command.StockId,
                FaultId = command.FaultId,
                Is_active=command.Is_active,
                Ins_date=command.Ins_date,
                Ins_user=command.Ins_user
            });
        }
    }
}
