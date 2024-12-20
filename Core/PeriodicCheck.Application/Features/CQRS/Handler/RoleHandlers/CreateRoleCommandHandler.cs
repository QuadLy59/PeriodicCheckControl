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
    public class CreateRoleCommandHandler
    {
        private readonly IRepository<Role> _repository;

        public CreateRoleCommandHandler(IRepository<Role> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateRoleCommand command)
        {
            await _repository.CreateAsync(new Role
            {
                Role_Name = command.Role_Name,
                Description = command.Description,
                Ins_user = command.Ins_user,
                Ins_date = command.Ins_date,
                Is_active = command.Is_active,
            });
        }
    }
}
