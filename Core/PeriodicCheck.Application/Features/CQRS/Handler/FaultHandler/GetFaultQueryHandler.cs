using PeriodicCheck.Application.Features.CQRS.Results.FaultResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;

namespace PeriodicCheck.Application.Features.CQRS.Handler.FaultHandler
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
            return values.Select(x => new GetFaultQueryResult
            {
                FaultId = x.FaultId,
                Selected_Fault = x.Selected_Fault,
                Report_Date = x.Report_Date,
                Report_Person = x.Report_Person,
                Solution_Date = x.Solution_Date,
                Solution_Person = x.Solution_Person,
                Case = x.Case,
                Fault_Description = x.Fault_Description,
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
