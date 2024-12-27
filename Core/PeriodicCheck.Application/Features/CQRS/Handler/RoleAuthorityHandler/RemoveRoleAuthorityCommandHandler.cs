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
    public class RemoveRoleAuthorityCommandHandler
    {
        private readonly IRepository<RoleAuthority> _repository;

        public RemoveRoleAuthorityCommandHandler(IRepository<RoleAuthority> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveRoleAuthorityCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
