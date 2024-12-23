using PeriodicCheck.Application.Features.CQRS.Results.StockResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.StockHandler
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
            return values.Select(x => new GetStockQueryResult
            {
                StockId = x.StockId,
                EquipmentId = x.EquipmentId,
                CategoryId = x.CategoryId,
                Ins_user = x.Ins_user,
                Ins_date = x.Ins_date,
                Updated_user = x.Updated_user,
                Updated_date = x.Updated_date,
                Deleted_user = x.Deleted_user,
                Deleted_date = x.Deleted_date,
                Is_active = x.Is_active,
                Is_deleted = x.Is_deleted
            }).ToList();
        }
    }
}
