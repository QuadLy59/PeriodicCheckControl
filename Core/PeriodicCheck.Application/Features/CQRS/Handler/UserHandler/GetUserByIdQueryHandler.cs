using PeriodicCheck.Application.Features.CQRS.Queries.UserQueries;
using PeriodicCheck.Application.Features.CQRS.Results.UserResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.UserHandler
{
    public class GetUserByIdQueryHandler
    {
        private readonly IRepository<User> _repository;

        public GetUserByIdQueryHandler(IRepository<User> repository)
        {
            _repository = repository;
        }
        public async Task<GetUserByIdQueryResult> Handle(GetUserByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetUserByIdQueryResult
            {
                UserId = values.UserId,
                RoleId = values.RoleId,
                Name_And_Surname = values.Name_And_Surname,
                Phone_Number = values.Phone_Number,
                Email = values.Email,
                Password = values.Password,
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
