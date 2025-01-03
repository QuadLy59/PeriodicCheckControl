﻿using PeriodicCheck.Application.Features.CQRS.Command.RoleCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.RoleHandler
{
    public class UpdateRoleCommandHandler
    {
        private readonly IRepository<Role> _repository;

        public UpdateRoleCommandHandler(IRepository<Role> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateRoleCommand command)
        {
            var values = await _repository.GetByIdAsync(command.RoleId);
            values.Role_Name = command.Role_Name;
            values.Description = command.Description;
            values.Updated_user = command.Updated_user;
            values.Updated_date = command.Updated_date;
            values.Is_active = command.Is_active;
            await _repository.UpdateAsync(values);
        }
    }
}
