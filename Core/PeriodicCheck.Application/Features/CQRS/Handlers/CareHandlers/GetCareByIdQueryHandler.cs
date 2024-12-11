using PeriodicCheck.Application.Features.CQRS.Queries.CareQueries;
using PeriodicCheck.Application.Features.CQRS.Results.CareResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handlers.CareHandlers
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
                Care_id = values.Care_id,
                Care_date = values.Care_date,
                Care_report = values.Care_report,
                Equipment_id = values.Equipment_id,
                next_care = values.next_care,
                Techinician = values.Techinician,
                Ins_date = values.Ins_date,
                Deleted_date = values.Deleted_date,
                Deleted_user = values.Deleted_user,
                Ins_user = values.Ins_user,
                Is_active = values.Is_active,
                Is_deleted = values.Is_deleted,
                Updated_date = values.Updated_date,
                Updated_user = values.Updated_user,
            };
        }
    }
}
