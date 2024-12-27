using PeriodicCheck.Application.Features.CQRS.Results.AuthorityResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.AuthorityHandler
{
    public class GetAuthorityQueryHandler
    {
        private readonly IRepository<Authority> _repository;

        public GetAuthorityQueryHandler(IRepository<Authority> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetAuthorityQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAuthorityQueryResult
            {
                AuthorityId=x.AuthorityId,
                AuthorityName=x.AuthorityName,
                Description=x.Description,
                Ins_date=x.Ins_date,
                Ins_user=x.Ins_user,
                Deleted_date=x.Deleted_date,
                Deleted_user=x.Deleted_user,
                Updated_date=x.Updated_date,
                Updated_user=x.Updated_user,
                Is_active=x.Is_active,
                Is_deleted=x.Is_deleted
            }).ToList();
        }
    }
}
