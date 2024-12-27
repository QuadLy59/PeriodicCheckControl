using PeriodicCheck.Application.Features.CQRS.Queries.CareNameQueries;
using PeriodicCheck.Application.Features.CQRS.Results.CareNameResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.CareNameHandler
{
    public class GetCareNameByIdQueryHandler
    {
        private readonly IRepository<CareName> _repository;

        public GetCareNameByIdQueryHandler(IRepository<CareName> repository)
        {
            _repository = repository;
        }
        public async Task<GetCareNameByIdQueryResult> Handle(GetCareNameByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCareNameByIdQueryResult
            {
                CareNameId = values.CareNameId,
                Care_Name = values.Care_Name,
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
