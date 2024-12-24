using PeriodicCheck.Application.Features.CQRS.Queries.RoleQueries;
using PeriodicCheck.Application.Features.CQRS.Results.FaultDetailResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.FaultDetailHandler
{
    public class GetFaultDetailByIdQueryHandler
    {
        private readonly IRepository<FaultDetail> _repository;

        public GetFaultDetailByIdQueryHandler(IRepository<FaultDetail> repository)
        {
            _repository = repository;
        }

        public async Task<GetFaultDetailByIdQueryResult> Handle(GetFaultDetailByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetFaultDetailByIdQueryResult
            {
                FaultDetailId = values.FaultDetailId,
                EquipmentId = values.EquipmentId,
                CategoryId = values.CategoryId,
                FaultId = values.FaultId,
                Report_Date = values.Report_Date,
                Report_Person = values.Report_Person,
                Solution_Date = values.Solution_Date,
                Solution_Person = values.Solution_Person,
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
