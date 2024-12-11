using PeriodicCheck.Application.Features.CQRS.Results.StockResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handlers.StockHandlers
{
    public class GetStockQueryHandler
    {
        private readonly IRepository<Stock> _repository;

        public GetStockQueryHandler(IRepository<Stock> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetStockQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=> new GetStockQueryResult
            {
                Deleted_user = x.Deleted_user,
                Deleted_date = x.Deleted_date,
                Equipment_id = x.Equipment_id,
                Ins_date = x.Ins_date,
                Ins_user = x.Ins_user,
                Is_active = x.Is_active,
                Is_deleted = x.Is_deleted,
                Location = x.Location,
                Quantity = x.Quantity,
                Situtation = x.Situtation,
                Stock_id = x.Stock_id,
                Updated_date = x.Updated_date,
                Updated_user = x.Updated_user
                
            }).ToList();
        }
    }
}
