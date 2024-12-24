using PeriodicCheck.Application.Features.CQRS.Results.MaterialResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.MaterialHandler
{
    public class GetMaterialQueryHandler
    {
        private readonly IRepository<Material> _repository;

        public GetMaterialQueryHandler(IRepository<Material> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetMaterialQueryResult>> Handle()
        {
            var materials = await _repository.GetAllAsync();
            return materials.Select(x => new GetMaterialQueryResult
            {
                MaterialId = x.MaterialId,
                Material_Name = x.Material_Name,
                CareId = x.CareId,
                EquipmentId = x.EquipmentId,
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
