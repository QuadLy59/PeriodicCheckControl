using PeriodicCheck.Application.Features.CQRS.Queries.EquipmentQueries;
using PeriodicCheck.Application.Features.CQRS.Results.EquipmentResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handlers.EquipmentHandlers
{
    public class GetEquipmentByIdQueryHandler
    {
        private readonly IRepository<Equipment> _repository;

        public GetEquipmentByIdQueryHandler(IRepository<Equipment> repository)
        {
            _repository = repository;
        }
        public async Task<GetEquipmentByIdQueryResult> Handle(GetEquipmentByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetEquipmentByIdQueryResult
            {
                Equipment_id = values.Equipment_id,
                Equipment_name = values.Equipment_name,
                Serial_no = values.Serial_no,
                Company = values.Company,
                Warehouse_id = values.Warehouse_id,
                Responsible = values.Responsible,
                Communication = values.Communication,
                Category_id = values.Category_id,
                Deleted_date = values.Deleted_date,
                Deleted_user = values.Deleted_user,
                Ins_date = values.Ins_date,
                Ins_user = values.Ins_user,
                Is_active = values.Is_active,
                Is_deleted = values.Is_deleted,
                Updated_date = values.Updated_date,
                Updated_user = values.Updated_user,
            };
        }
    }
}
