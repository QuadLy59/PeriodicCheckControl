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
    public class GetCareReportQueryHandler
    {
        private readonly IRepository<CareReport> _repository;

        public GetCareReportQueryHandler(IRepository<CareReport> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCareReportQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCareReportQueryResult
            {
                CareReportId = x.CareReportId,
                CareReportDate = x.CareReportDate,
                CareId = x.CareId,
                EquipmentId = x.EquipmentId,
                CategoryId = x.CategoryId,
                MaterialId = x.MaterialId,
                Ins_user = x.Ins_user,
                Ins_date = x.Ins_date,
                Updated_user = x.Updated_user,
                Updated_date = x.Updated_date,
                Deleted_user = x.Deleted_user,
                Deleted_date = x.Deleted_date,
                Is_active = x.Is_active,
                Is_deleted = x.Is_deleted,

            }).ToList();
        }
    }
}
