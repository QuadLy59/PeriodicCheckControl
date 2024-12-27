using PeriodicCheck.Application.Features.CQRS.Results.WarehouseResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.WarehouseHandler
{
    public class GetWarehouseQueryHandler
    {
        private readonly IRepository<Warehouse> _repository;

        public GetWarehouseQueryHandler(IRepository<Warehouse> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetWarehouseQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetWarehouseQueryResult
            {
                WarehouseId = x.WarehouseId,
                Warehouse_Name = x.Warehouse_Name,
                Ins_date = x.Ins_date,
                Ins_user = x.Ins_user,
                Deleted_date = x.Deleted_date,
                Deleted_user = x.Deleted_user,
                Updated_date = x.Updated_date,
                Updated_user = x.Updated_user,
                Is_active = x.Is_active,
                Is_deleted = x.Is_deleted
            }).ToList();
        }
    }
}
