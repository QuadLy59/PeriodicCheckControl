using PeriodicCheck.Application.Features.CQRS.Queries.CareReportQueries;
using PeriodicCheck.Application.Features.CQRS.Results.CareReportResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.CareReportHandler
{
    public class GetCareReportByIdQueryHandler
    {
        private readonly IRepository<CareReport> _repository;

        public GetCareReportByIdQueryHandler(IRepository<CareReport> repository)
        {
            _repository = repository;
        }
        public async Task<GetCareReportByIdQueryResult> Handle(GetCareReportByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCareReportByIdQueryResult
            {
                CareReportId = values.CareReportId,
                CareReportDate=values.CareReportDate,
                CareId=values.CareId,
                EquipmentId=values.EquipmentId,
                CategoryId=values.CategoryId,
                MaterialId=values.MaterialId,
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
