using PeriodicCheck.Application.Features.CQRS.Queries.FaultNameQueries;
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
    public class GetFaultNameByIdQueryHandler
    {
        private readonly IRepository<FaultName> _repository;

        public GetFaultNameByIdQueryHandler(IRepository<FaultName> repository)
        {
            _repository = repository;
        }
        public async Task<GetFaultNameByIdQueryResult>Handle(GetFaultNameByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetFaultNameByIdQueryResult
            {
                FaultNameId = values.FaultNameId,
                Fault_Name = values.Fault_Name,
                Ins_user = values.Ins_user,
                Ins_date = values.Ins_date,
                Updated_user = values.Updated_user,
                Updated_date = values.Updated_date,
                Deleted_user = values.Deleted_user,
                Deleted_date = values.Deleted_date,
                Is_active = values.Is_active,
                Is_deleted = values.Is_deleted,
            };
        }
    }
}
