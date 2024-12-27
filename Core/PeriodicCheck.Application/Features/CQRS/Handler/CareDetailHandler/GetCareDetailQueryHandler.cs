using PeriodicCheck.Application.Features.CQRS.Results.CareDetailResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.CareDetailHandler
{
    public class GetCareDetailQueryHandler
    {
        private readonly IRepository<CareDetail> _repository;

        public GetCareDetailQueryHandler(IRepository<CareDetail> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCareDetailQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCareDetailQueryResult
            {
                CareDetailId = x.CareDetailId,
                CareId = x.CareId,
                MaterialId = x.MaterialId,
                CareNameId=x.CareNameId,
                Selected_Care = x.Selected_Care,
                Care_Date = x.Care_Date,
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
