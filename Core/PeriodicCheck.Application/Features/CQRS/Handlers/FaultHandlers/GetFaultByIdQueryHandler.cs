using PeriodicCheck.Application.Features.CQRS.Queries.FaultQueries;
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
    public class GetFaultByIdQueryHandler
    {
        private readonly IRepository<Fault> _repository;

        public GetFaultByIdQueryHandler(IRepository<Fault> repository)
        {
            _repository = repository;
        }
        public async Task<GetFaultByIdQueryResult> Handle(GetFaultByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetFaultByIdQueryResult
            {
                Fault_id = values.Fault_id,
                Case = values.Case,
                Deleted_date = values.Deleted_date,
                Deleted_user = values.Deleted_user,
                Equipment_id = values.Equipment_id,
                Fault_description = values.Fault_description,
                Ins_date = values.Ins_date,
                Ins_user = values.Ins_user,
                Is_active = values.Is_active,
                Is_deleted = values.Is_deleted,
                Report_date = values.Report_date,
                Report_person = values.Report_person,
                Solution_date = values.Solution_date,
                Solution_person = values.Solution_person,
                Updated_date = values.Updated_date,
                Updated_user = values.Updated_user
            };
        }
    }
}
