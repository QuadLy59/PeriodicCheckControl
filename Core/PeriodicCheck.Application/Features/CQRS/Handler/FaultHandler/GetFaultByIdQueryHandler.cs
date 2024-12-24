using PeriodicCheck.Application.Features.CQRS.Queries.RoleQueries;
using PeriodicCheck.Application.Features.CQRS.Results.FaultResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.FaultHandler
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
                FaultId = values.FaultId,
                Fault_Name = values.Fault_Name,
                Selected_Fault = values.Selected_Fault,
                Case = values.Case,
                Fault_Description = values.Fault_Description,
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
