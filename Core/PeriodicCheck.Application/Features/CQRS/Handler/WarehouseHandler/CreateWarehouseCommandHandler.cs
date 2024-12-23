using PeriodicCheck.Application.Features.CQRS.Command.WarehouseCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.WarehouseHandler
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
                Warehouse_Name = command.Warehouse_Name,
                EquipmentId = command.EquipmentId,
                Ins_user = command.Ins_user,
                Ins_date = command.Ins_date,
                Deleted_date = command.Deleted_date,
                Deleted_user = command.Deleted_user,
                Updated_date = command.Updated_date,
                Updated_user = command.Updated_user,
                Is_active = command.Is_active,
                Is_deleted = command.Is_deleted
            });
        }
    }
}
