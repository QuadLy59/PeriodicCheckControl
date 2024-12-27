using PeriodicCheck.Application.Features.CQRS.Results.FaultNameResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.FaultNameHandler
{
    public class GetFaultNameQueryHandler
    {
        private readonly IRepository<FaultName> _repository;

        public GetFaultNameQueryHandler(IRepository<FaultName> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetFaultNameQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=> new GetFaultNameQueryResult
            {
                FaultNameId= x.FaultNameId,
                Fault_Name=x.Fault_Name,
                Ins_user = x.Ins_user,
                Ins_date = x.Ins_date,
                Updated_user = x.Updated_user,
                Updated_date = x.Updated_date,
                Deleted_user = x.Deleted_user,
                Deleted_date = x.Deleted_date,
                Is_active = x.Is_active,
                Is_deleted = x.Is_deleted,
            }).ToList();
        }
    }
}
