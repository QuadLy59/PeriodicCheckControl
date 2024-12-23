using PeriodicCheck.Application.Features.CQRS.Command.StockCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.StockHandler
{
    public class RemoveStockCommandHandler
    {
        private readonly IRepository<Stock> _repository;

        public RemoveStockCommandHandler(IRepository<Stock> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveStockCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
