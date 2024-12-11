using PeriodicCheck.Application.Features.CQRS.Commands.StockCommands;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handlers.StockHandlers
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
                Equipment_id = command.Equipment_id,
                Ins_date = command.Ins_date,
                Ins_user = command.Ins_user,
                Is_active = command.Is_active,
                Location    = command.Location,
                Quantity = command.Quantity,
                Situtation = command.Situtation,
            });
        }
    }
}
