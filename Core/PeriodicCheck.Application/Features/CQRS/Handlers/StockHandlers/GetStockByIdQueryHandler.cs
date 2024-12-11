using PeriodicCheck.Application.Features.CQRS.Queries.StockQueries;
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
    public class GetStockByIdQueryHandler
    {
        private readonly IRepository<Stock> _repository;

        public GetStockByIdQueryHandler(IRepository<Stock> repository)
        {
            _repository = repository;
        }
        public async Task<GetStockByIdQueryResult> Handle(GetStockByIdQuery query)
        {
            var values =await _repository.GetByIdAsync(query.Id);
            return new GetStockByIdQueryResult
            {
                Equipment_id = values.Equipment_id,
                Deleted_date = values.Deleted_date,
                Stock_id = values.Stock_id,
                Deleted_user = values.Deleted_user,
                Ins_date = values.Ins_date,
                Ins_user = values.Ins_user,
                Is_active = values.Is_active,
                Is_deleted = values.Is_deleted,
                Location = values.Location,
                Quantity = values.Quantity,
                Situtation = values.Situtation,
                Updated_date = values.Updated_date,
                Updated_user = values.Updated_user,
                
            };
        }
    }
}
