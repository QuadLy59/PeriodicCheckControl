using PeriodicCheck.Application.Features.CQRS.Command.StockCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.StockHandler
{
    public class UpdateStockCommandHandler
    {
        private readonly IRepository<Stock> _repository;

        public UpdateStockCommandHandler(IRepository<Stock> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateStockCommand command)
        {
            var values = await _repository.GetByIdAsync(command.StockId);
            values.EquipmentId = command.EquipmentId;
            values.CategoryId = command.CategoryId;
            values.Updated_user = command.Updated_user;
            values.Updated_date = command.Updated_date;
            values.Is_active = command.Is_active;
            values.Is_deleted = command.Is_deleted;
            await _repository.UpdateAsync(values);
        }
    }
}
