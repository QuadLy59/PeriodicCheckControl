using PeriodicCheck.Application.Features.CQRS.Queries.CareDetailQueries;
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
    public class GetCareDetailByIdQueryHandler
    {
        private readonly IRepository<CareDetail> _repository;

        public GetCareDetailByIdQueryHandler(IRepository<CareDetail> repository)
        {
            _repository = repository;
        }
        public async Task <GetCareDetailByIdQueryResult>Handle(GetCareDetailByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCareDetailByIdQueryResult
            {
                CareDetailId = values.CareDetailId,
                CareId=values.CareId,
                MaterialId=values.MaterialId,
                CareNameId=values.CareNameId,
                Selected_Care=values.Selected_Care,
                Care_Date = values.Care_Date,
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
