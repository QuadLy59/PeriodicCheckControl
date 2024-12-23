using PeriodicCheck.Application.Features.CQRS.Queries.EquipmentQueries;
using PeriodicCheck.Application.Features.CQRS.Results.EquipmentResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.EquipmentHandler
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
                EquipmentId = values.EquipmentId,
                Equipment_Name=values.Equipment_Name,
                Serial_No=values.Serial_No,
                Company=values.Company,
                WarehouseId=values.WarehouseId,
                Responsible=values.Responsible,
                Responsible_Communication=values.Responsible_Communication,
                Shift_Turn=values.Shift_Turn,
                CategoryId=values.CategoryId,
                CareId=values.CareId,
                StockId=values.StockId,
                FaultId=values.FaultId,
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
