using PeriodicCheck.Application.Features.CQRS.Queries.AuthorityQueries;
using PeriodicCheck.Application.Features.CQRS.Results.WarehouseResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.WarehouseHandler
{
    public class GetWarehouseByIdQueryHandler
    {
        private readonly IRepository<Warehouse> _repository;

        public GetWarehouseByIdQueryHandler(IRepository<Warehouse> repository)
        {
            _repository = repository;
        }

        public async Task<GetWarehouseByIdQueryResult> Handle(GetWarehouseByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetWarehouseByIdQueryResult
            {
                WarehouseId = values.WarehouseId,
                Warehouse_Name = values.Warehouse_Name,
                EquipmentId = values.EquipmentId,
                Ins_date = values.Ins_date,
                Ins_user = values.Ins_user,
                Updated_user = values.Updated_user,
                Updated_date = values.Updated_date,
                Deleted_date = values.Deleted_date,
                Deleted_user = values.Deleted_user,
                Is_active = values.Is_active,
                Is_deleted = values.Is_deleted
            };
        }
    }
}
