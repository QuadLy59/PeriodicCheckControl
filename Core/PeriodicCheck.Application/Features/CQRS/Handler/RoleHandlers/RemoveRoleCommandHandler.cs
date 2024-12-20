using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using SurveySystem.Application.Features.CQRS.Commands.RoleCommands;

namespace SurveySystem.Application.Features.CQRS.Handlers.RoleHandlers
{
    public class RemoveRoleCommandHandler
    {
        private readonly IRepository<Role> _repository;

        public RemoveRoleCommandHandler(IRepository<Role> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveRoleCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
