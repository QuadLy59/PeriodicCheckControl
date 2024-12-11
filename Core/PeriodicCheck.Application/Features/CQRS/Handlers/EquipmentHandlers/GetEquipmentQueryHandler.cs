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
    public class GetEquipmentQueryHandler
    {
        private readonly IRepository<Equipment> _repository;

        public GetEquipmentQueryHandler(IRepository<Equipment> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetEquipmentQueryResult>> Handle()
        {
            var values =await _repository.GetAllAsync();
            return values.Select(x=> new GetEquipmentQueryResult
            {
                Equipment_id = x.Equipment_id,
                Equipment_name = x.Equipment_name,
                Serial_no = x.Serial_no,
                Company = x.Company,
                Warehouse_id = x.Warehouse_id,
                Responsible = x.Responsible,
                Communication = x.Communication,
                Category_id = x.Category_id,
                Deleted_date = x.Deleted_date,
                Deleted_user = x.Deleted_user,
                Ins_date = x.Ins_date,
                Ins_user = x.Ins_user,
                Is_active = x.Is_active,
                Is_deleted = x.Is_deleted,
                Updated_date = x.Updated_date,
                Updated_user = x.Updated_user,
                
                
            }).ToList();
        }
    }
}
