using PeriodicCheck.Application.Features.CQRS.Queries.WarehouseQueries;
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
    public class GetWarehouseByIdQueryHandler
    {
        private readonly IRepository<Warehouse> _repository;

        public GetWarehouseByIdQueryHandler(IRepository<Warehouse> repository)
        {
            _repository = repository;
        }
        public async Task<GetWarehouseByIdQueryResult> Handle(GetWarehouseByIdQuery query)
        {
            var values =await _repository.GetByIdAsync(query.Id);
            return new GetWarehouseByIdQueryResult
            {
                Warehouse_id=values.Warehouse_id,
                Ins_date=values.Ins_date,
                Deleted_user=values.Deleted_user,
                Deleted_date=values.Deleted_date,
                Ins_user=values.Ins_user,
                Is_active=values.Is_active,
                Is_deleted=values.Is_deleted,
                Updated_date=values.Updated_date,
                Updated_user=values.Updated_user,
                Warehouse_name = values.Warehouse_name  
                
            };
        }
    }
}
