using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using SurveySystem.Application.Features.CQRS.Queries.RoleQueries;
using SurveySystem.Application.Features.CQRS.Results.RoleResults;

namespace SurveySystem.Application.Features.CQRS.Handlers.RoleHandlers
{
    public class GetRoleByIdQueryHandler
    {
        private readonly IRepository<Role> _repository;

        public GetRoleByIdQueryHandler(IRepository<Role> repository)
        {
            _repository = repository;
        }
        public async Task<GetRoleByIdQueryResult> Handle(GetRoleByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetRoleByIdQueryResult
            {
                RoleId = values.RoleId,
                Role_Name = values.Role_Name,
                Description = values.Description,
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
