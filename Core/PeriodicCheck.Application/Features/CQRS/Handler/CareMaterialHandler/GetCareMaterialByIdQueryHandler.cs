using PeriodicCheck.Application.Features.CQRS.Queries.CareMaterialQueries;
using PeriodicCheck.Application.Features.CQRS.Results.CareMaterialResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.CareMaterialHandler
{
    public class GetCareMaterialByIdQueryHandler
    {
        private readonly IRepository<CareMaterial> _repository;

        public GetCareMaterialByIdQueryHandler(IRepository<CareMaterial> repository)
        {
            _repository = repository;
        }
        public async Task<GetCareMaterialByIdQueryResult> Handle(GetCareMaterialByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCareMaterialByIdQueryResult
            {
                CareMaterialId=values.CareMaterialId,
                CareId=values.CareId,
                MaterialId=values.MaterialId,
                Ins_user = values.Ins_user,
                Ins_date = values.Ins_date,
                Updated_user = values.Updated_user,
                Updated_date = values.Updated_date,
                Deleted_user = values.Deleted_user,
                Deleted_date = values.Deleted_date,
                Is_active = values.Is_active,
                Is_deleted=values.Is_deleted
            };

        }
    }
}
