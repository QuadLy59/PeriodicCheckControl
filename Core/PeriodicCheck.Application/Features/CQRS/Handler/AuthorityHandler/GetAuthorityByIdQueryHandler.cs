using PeriodicCheck.Application.Features.CQRS.Queries.AuthorityQueries;
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
    public class GetAuthorityByIdQueryHandler
    {
        private readonly IRepository<Authority> _repository;

        public GetAuthorityByIdQueryHandler(IRepository<Authority> repository)
        {
            _repository = repository;
        }
        public async Task<GetAuthorityByIdQueryResult> Handle(GetAuthorityByIdQuery query)
        {
            var values= await _repository.GetByIdAsync(query.Id);
            return new GetAuthorityByIdQueryResult
            {
                Authority_id=values.AuthorityId,
                Authority_Name=values.AuthorityName,
                Description=values.Description,
                Ins_date=values.Ins_date,
                Ins_user=values.Ins_user,
                Updated_user=values.Updated_user,
                Updated_date=values.Updated_date,
                Deleted_date=values.Deleted_date,
                Deleted_user=values.Deleted_user,
                Is_active=values.Is_active,
                Is_deleted=values.Is_deleted
            };
        }
    }
}
