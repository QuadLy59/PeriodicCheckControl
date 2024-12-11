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
    public class UpdateStockCommandHandler
    {
        private readonly IRepository<Stock> _repository;

        public UpdateStockCommandHandler(IRepository<Stock> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateStockCommand command)
        {
            var values= await _repository.GetByIdAsync(command.Stock_id);
            values.Situtation=command.Situtation;
            values.Location=command.Location;
            values.Quantity=command.Quantity;
            values.Equipment_id=command.Equipment_id;
            values.Is_active=command.Is_active;
            values.Updated_date=command.Updated_date;
            values.Updated_user=command.Updated_user;
            await _repository.UpdateAsync(values);
        }
    }
}
