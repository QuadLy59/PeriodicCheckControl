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
    public class GetUserQueryHandler
    {
        private readonly IRepository<User> _repository;

        public GetUserQueryHandler(IRepository<User> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetUserQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetUserQueryResult
            {
                UserId = x.UserId,
                RoleId = x.RoleId,
                Name_And_Surname = x.Name_And_Surname,
                Phone_Number = x.Phone_Number,
                Email = x.Email,
                Password = x.Password,
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
