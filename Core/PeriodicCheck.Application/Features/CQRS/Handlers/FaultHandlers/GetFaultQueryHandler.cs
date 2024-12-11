using PeriodicCheck.Application.Features.CQRS.Results.FaultResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handlers.FaultHandlers
{
    public class GetFaultQueryHandler
    {
        private readonly IRepository<Fault> _repository;

        public GetFaultQueryHandler(IRepository<Fault> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetFaultQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=> new GetFaultQueryResult
            {
                Fault_id = x.Fault_id,
                Equipment_id = x.Equipment_id,
                Case = x.Case,
                Deleted_date = x.Deleted_date,
                Deleted_user = x.Deleted_user,
                Fault_description = x.Fault_description,
                Ins_date = x.Ins_date,
                Ins_user = x.Ins_user,
                Is_active = x.Is_active,
                Is_deleted = x.Is_deleted,
                Report_date = x.Report_date,
                Report_person = x.Report_person,
                Solution_date = x.Solution_date,
                Solution_person = x.Solution_person,
                Updated_date = x.Updated_date,
                Updated_user = x.Updated_user,
                
            }).ToList();
        }
    }
}
