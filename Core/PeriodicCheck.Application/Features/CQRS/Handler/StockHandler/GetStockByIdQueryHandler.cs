using PeriodicCheck.Application.Features.CQRS.Queries.StockQuery;
using PeriodicCheck.Application.Features.CQRS.Results.StockResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.StockHandler
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
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetStockByIdQueryResult
            {
                StockId = values.StockId,
                EquipmentId = values.EquipmentId,
                CategoryId = values.CategoryId,
                Ins_user = values.Ins_user,
                Ins_date = values.Ins_date,
                Updated_user = values.Updated_user,
                Updated_date = values.Updated_date,
                Deleted_user = values.Deleted_user,
                Deleted_date = values.Deleted_date,
                Is_active = values.Is_active,
                Is_deleted = values.Is_deleted
            };
        }
    }
}
