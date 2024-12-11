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
    public class GetCareQueryHandler
    {
        private readonly IRepository<Care> _repository;

        public GetCareQueryHandler(IRepository<Care> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCareQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCareQueryResult
            {
                Care_id = x.Care_id,
                Care_date = x.Care_date,
                Care_report = x.Care_report,
                Equipment_id = x.Equipment_id,
                next_care=x.next_care,
                Techinician=x.Techinician,
                Deleted_date=x.Deleted_date,
                Deleted_user=x.Deleted_user,
                Ins_date=x.Ins_date,
                Ins_user=x.Ins_user,
                Is_active=x.Is_active,
                Is_deleted=x.Is_deleted,
                Updated_date=x.Updated_date,
                Updated_user=x.Updated_user,      
            }).ToList();
        }
    }
}
