using PeriodicCheck.Application.Features.CQRS.Results.CareResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.CareHandler
{
    public class GetCareQueryHandler
    {
        private readonly IRepository<Care> _repository;

        public GetCareQueryHandler(IRepository<Care> repository)
        {
            _repository = repository;
        }
        public async Task <List<GetCareQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCareQueryResult
            {
                CareId = x.CareId,
                EquipmentId = x.EquipmentId,

                Technician=x.Technician,
                Next_Care_Date=x.Next_Care_Date,
                Previ_Care_Date=x.Previ_Care_Date,
                Control_Type=x.Control_Type,
                Care_Description=x.Care_Description,
                Care_Photo = x.Care_Photo,
                Ins_date =x.Ins_date,
                Ins_user=x.Ins_user,
                Updated_date=x.Updated_date,
                Updated_user=x.Updated_user,
                Deleted_date=x.Deleted_date,
                Deleted_user=x.Deleted_user,
                Is_active=x.Is_active,
                Is_deleted=x.Is_deleted
            }).ToList();
        }
    }
}
