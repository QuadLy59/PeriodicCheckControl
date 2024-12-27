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
    public class UpdateAuthorityCommandHandler
    {
        private readonly IRepository<Authority> _repository;

        public UpdateAuthorityCommandHandler(IRepository<Authority> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateAuthorityCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Authority_id);
            values.AuthorityName = command.AuthorityName;
            values.Description = command.Description;
            values.Ins_user= command.Ins_user;
            values.Ins_date = command.Ins_date;
            values.Updated_date= command.Updated_date;
            values.Updated_user=command.Updated_user;
            values.Deleted_date = command.Deleted_date;
            values.Deleted_user = command.Deleted_user;
            values.Is_active = command.Is_active;
            values.Is_deleted = command.Is_deleted;
            await _repository.UpdateAsync(values);
        }
    }
}
