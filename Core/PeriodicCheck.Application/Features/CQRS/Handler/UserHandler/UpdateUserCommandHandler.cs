using PeriodicCheck.Application.Features.CQRS.Command.UserCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.UserHandler
{
    public class UpdateUserCommandHandler
    {
        private readonly IRepository<User> _repository;

        public UpdateUserCommandHandler(IRepository<User> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateUserCommand command)
        {
            var values = await _repository.GetByIdAsync(command.UserId);
            values.RoleId = command.RoleId;
            values.Name_And_Surname = command.Name_And_Surname;
            values.Phone_Number = command.Phone_Number;
            values.Email = command.Email;
            values.Password = command.Password;
            values.Updated_user = command.Updated_user;
            values.Updated_date = command.Updated_date;
            values.Is_active = command.Is_active;
            await _repository.UpdateAsync(values);
        }

    }
}
