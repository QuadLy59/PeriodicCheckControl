using PeriodicCheck.Application.Features.CQRS.Command.AuthorityCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.AuthorityHandler
{
    public class CreateAuthorityCommandHandler
    {
        private readonly IRepository<Authority> _repository;

        public CreateAuthorityCommandHandler(IRepository<Authority> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateAuthorityCommand command)
        {
            await _repository.CreateAsync(new Authority
            {
                AuthorityName= command.AuthorityName,
                Description=command.Description,
                Ins_user=command.Ins_user,
                Ins_date=command.Ins_date,
                Deleted_date=command.Deleted_date,
                Deleted_user=command.Deleted_user,
                Updated_date=command.Updated_date,
                Updated_user=command.Updated_user,
                Is_active=command.Is_active,
                Is_deleted=command.Is_deleted
            });
        }
    }
}
