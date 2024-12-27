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
    public class CreateRoleAuthorityCommandHandler
    {
        private readonly IRepository<RoleAuthority> _repository;

        public CreateRoleAuthorityCommandHandler(IRepository<RoleAuthority> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateRoleAuthorityCommand command)
        {
            await _repository.CreateAsync(new RoleAuthority
            {
                RoleId = command.RoleId,
                AuthorityId = command.AuthorityId,
                Ins_user = command.Ins_user,
                Ins_date = command.Ins_date,
                Is_active = command.Is_active,
            });
        }
    }
}
