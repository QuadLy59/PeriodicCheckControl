using PeriodicCheck.Application.Features.CQRS.Queries.RoleQueries;
using PeriodicCheck.Application.Features.CQRS.Results.MaterialResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.MaterialHandler
{
    public class GetMaterialByIdQueryHandler
    {
        private readonly IRepository<Material> _repository;

        public GetMaterialByIdQueryHandler(IRepository<Material> repository)
        {
            _repository = repository;
        }

        public async Task<GetMaterialByIdQueryResult> Handle(GetMaterialByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetMaterialByIdQueryResult
            {
                MaterialId = values.MaterialId,
                Material_Name = values.Material_Name,
                CareId = values.CareId,
                EquipmentId = values.EquipmentId,
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
