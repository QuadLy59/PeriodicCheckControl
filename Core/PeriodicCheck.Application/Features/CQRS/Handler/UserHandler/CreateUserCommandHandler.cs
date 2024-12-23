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
    public class CreateUserCommandHandler
    {
        private readonly IRepository<User> _repository;

        public CreateUserCommandHandler(IRepository<User> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateUserCommand command)
        {
            await _repository.CreateAsync(new User
            {
                RoleId = command.RoleId,
                Name_And_Surname = command.Name_And_Surname,
                Phone_Number = command.Phone_Number,
                Email = command.Email,
                Password = command.Password,
                Ins_user = command.Ins_user,
                Ins_date = command.Ins_date,
                Is_active = command.Is_active
                
            });
        }
    }
}
