using PeriodicCheck.Application.Features.CQRS.Queries.RoleAuthorityQueries;
using PeriodicCheck.Application.Features.CQRS.Results.RoleAuthorityResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.RoleAuthorityHandler
{
    public class GetRoleAuthorityByIdQueryHandler
    {
        private readonly IRepository<RoleAuthority> _repository;

        public GetRoleAuthorityByIdQueryHandler(IRepository<RoleAuthority> repository)
        {
            _repository = repository;
        }
        public async Task<GetRoleAuthorityByIdQueryResult> Handle(GetRoleAuthorityByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetRoleAuthorityByIdQueryResult
            {
                RoleAuthorityId = values.RoleAuthorityId,
                RoleId = values.RoleId,
                AuthorityId = values.AuthorityId,
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
