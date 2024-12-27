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
    public class GetCareNameQueryHandler
    {
        private readonly IRepository<CareName> _repository;

        public GetCareNameQueryHandler(IRepository<CareName> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCareNameQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCareNameQueryResult
            {
                CareNameId=x.CareNameId,
                Care_Name=x.Care_Name,
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
