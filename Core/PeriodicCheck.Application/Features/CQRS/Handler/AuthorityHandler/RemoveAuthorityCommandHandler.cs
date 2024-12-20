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
    public class RemoveAuthorityCommandHandler
    {
        private readonly IRepository<Authority> _repository;

        public RemoveAuthorityCommandHandler(IRepository<Authority> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveAuthorityCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
