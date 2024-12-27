using PeriodicCheck.Application.Features.CQRS.Command.RoleAuthorityCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.RoleAuthorityHandler
{
    public class UpdateRoleAuthorityCommandHandler
    {
        private readonly IRepository<RoleAuthority> _repository;

        public UpdateRoleAuthorityCommandHandler(IRepository<RoleAuthority> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateRoleAuthorityCommand command)
        {
            var values = await _repository.GetByIdAsync(command.RoleAuthorityId);
            values.RoleId = command.RoleId;
            values.AuthorityId = command.AuthorityId;
            values.Updated_user = command.Updated_user;
            values.Updated_date = command.Updated_date;
            values.Is_active = command.Is_active;
            await _repository.UpdateAsync(values);
        }
    }
}
