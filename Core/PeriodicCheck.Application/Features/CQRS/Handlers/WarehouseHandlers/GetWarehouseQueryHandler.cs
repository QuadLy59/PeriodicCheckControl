using PeriodicCheck.Application.Features.CQRS.Results.WarehouseResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handlers.WarehouseHandlers
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
            var values =await _repository.GetAllAsync();
            return values.Select(x=>new GetWarehouseQueryResult
            {
                 Warehouse_id = x.Warehouse_id,
                 Deleted_date = x.Deleted_date,
                 Deleted_user = x.Deleted_user,
                 Ins_date = x.Ins_date,
                 Ins_user = x.Ins_user,
                 Is_active = x.Is_active,
                 Is_deleted = x.Is_deleted,
                 Updated_date = x.Updated_date,
                 Updated_user = x.Updated_user,
                 Warehouse_name = x.Warehouse_name
            }).ToList();
        }
    }
}
