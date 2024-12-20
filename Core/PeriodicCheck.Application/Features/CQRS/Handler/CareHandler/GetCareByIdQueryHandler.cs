using PeriodicCheck.Application.Features.CQRS.Queries.CareQueries;
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
    public class GetCareByIdQueryHandler
    {
        private readonly IRepository<Care> _repository;

        public GetCareByIdQueryHandler(IRepository<Care> repository)
        {
            _repository = repository;
        }
        public async Task<GetCareByIdQueryResult> Handle(GetCareByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCareByIdQueryResult
            {
                Care_id=values.CareId,
                Equipment_id=values.EquipmentId,
                Care_Date=values.Care_Date,
                Technician=values.Technician,
                Next_Care_Date=values.Next_Care_Date,
                Previ_Care_Date=values.Previ_Care_Date,
                Control_Type=values.Control_Type,
                Care_Description=values.Care_Description,
                Ins_user=values.Ins_user,
                Ins_date=values.Ins_date,
                Updated_date=values.Updated_date,
                Updated_user=values.Updated_user,
                Deleted_date=values.Deleted_date,
                Deleted_user=values.Deleted_user,
                Is_active=values.Is_active,
                Is_deleted=values.Is_deleted
            };
        }
    }
}
