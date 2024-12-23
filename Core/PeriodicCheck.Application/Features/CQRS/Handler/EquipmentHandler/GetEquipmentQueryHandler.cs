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
    public class GetEquipmentQueryHandler
    {
        private readonly IRepository<Equipment> _repository;

        public GetEquipmentQueryHandler(IRepository<Equipment> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetEquipmentQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetEquipmentQueryResult
            {
                EquipmentId = x.EquipmentId,
                Equipment_Name = x.Equipment_Name,
                Serial_No = x.Serial_No,
                Company = x.Company,
                WarehouseId = x.WarehouseId,
                Responsible = x.Responsible,
                Responsible_Communication = x.Responsible_Communication,
                Shift_Turn = x.Shift_Turn,
                CategoryId = x.CategoryId,
                CareId = x.CareId,
                StockId = x.StockId,
                FaultId = x.FaultId,
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
