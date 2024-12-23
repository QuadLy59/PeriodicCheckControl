using PeriodicCheck.Application.Features.CQRS.Command.StockCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.StockHandler
{
    public class CreateStockCommandHandler
    {
        private readonly IRepository<Stock> _repository;

        public CreateStockCommandHandler(IRepository<Stock> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateStockCommand command)
        {
            await _repository.CreateAsync(new Stock
            {
                EquipmentId = command.EquipmentId,
                CategoryId = command.CategoryId,
                Ins_user = command.Ins_user,
                Ins_date = command.Ins_date,
                Is_active = command.Is_active,
                Is_deleted = false
            });
        }
    }
}
