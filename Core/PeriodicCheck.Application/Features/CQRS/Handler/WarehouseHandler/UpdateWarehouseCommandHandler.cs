using PeriodicCheck.Application.Features.CQRS.Command.WarehouseCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.WarehouseHandler
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
            var values = await _repository.GetByIdAsync(command.WarehouseId);
            values.Warehouse_Name = command.Warehouse_Name;
            values.EquipmentId = command.EquipmentId;
            values.Ins_user = command.Ins_user;
            values.Ins_date = command.Ins_date;
            values.Updated_date = command.Updated_date;
            values.Updated_user = command.Updated_user;
            values.Deleted_date = command.Deleted_date;
            values.Deleted_user = command.Deleted_user;
            values.Is_active = command.Is_active;
            values.Is_deleted = command.Is_deleted;
            await _repository.UpdateAsync(values);
        }
    }
}
