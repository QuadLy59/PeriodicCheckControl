using PeriodicCheck.Application.Features.CQRS.Queries.PeriodicActivityStatusQueries;
using PeriodicCheck.Application.Features.CQRS.Results.ActivityStatusResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handlers.PeriodicActivityStatusHandlers
{
    public class GetPeriodicActivityStatusByIdQueryHandler
    {
        private readonly IRepository<PeriodicActivityStatus> _repository;

        public GetPeriodicActivityStatusByIdQueryHandler(IRepository<PeriodicActivityStatus> repository)
        {
            _repository = repository;
        }
        public async Task<GetPeriodicActivityStatusByIdQueryResult> Handle(PeriodicActivityStatusByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetPeriodicActivityStatusByIdQueryResult
            {
                Activity_id = values.Activity_id,
                Equipment_id = values.Equipment_id,
                ActivityDate = values.ActivityDate,
                ActivityType = values.ActivityType,
                Description = values.Description,
                Fault_description = values.Fault_description,
                Report_date = values.Report_date,
                Report_person = values.Report_person,
                Solution_date = values.Solution_date,
                Solution_person = values.Solution_person,
                İncharge_mail = values.İncharge_mail,
                Care_date = values.Care_date,
                Techinician = values.Techinician,
                Care_report = values.Care_report,
                next_care = values.next_care,
                Quantity = values.Quantity,
                Situtation = values.Situtation,
                Notice_date = values.Notice_date,
                Notice_type = values.Notice_type,
                Deleted_date = values.Deleted_date,
                Deleted_user = values.Deleted_user,
                Ins_date = values.Ins_date,
                Ins_user = values.Ins_user,
                Is_active = values.Is_active,
                Is_deleted = values.Is_deleted,
                Updated_date = values.Updated_date,
                Updated_user = values.Updated_user,
            };
        }
    }
}
