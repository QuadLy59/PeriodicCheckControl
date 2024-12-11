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
    public class GetPeriodicActivityStatusQueryHandler
    {
        private readonly IRepository<PeriodicActivityStatus> _repository;

        public GetPeriodicActivityStatusQueryHandler(IRepository<PeriodicActivityStatus> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetPeriodicActivityStatusQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetPeriodicActivityStatusQueryResult { 
            Equipment_id = x.Equipment_id,
            Activity_id = x.Activity_id,
            ActivityType = x.ActivityType,
            Description = x.Description,
            ActivityDate = x.ActivityDate,
            Fault_description = x.Fault_description,
            Report_date = x.Report_date,
            Report_person = x.Report_person,
            Solution_date = x.Solution_date,
            Solution_person = x.Solution_person,
            İncharge_mail=x.İncharge_mail,
            Care_date = x.Care_date,
            Techinician=x.Techinician,
            Care_report=x.Care_report,
            next_care=x.next_care,
            Quantity=x.Quantity,
            Situtation=x.Situtation,
            Notice_date=x.Notice_date,
            Notice_type=x.Notice_type,
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
