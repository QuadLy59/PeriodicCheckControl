using PeriodicCheck.Application.Features.CQRS.Command.CareNameCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.CareNameHandler
{
    public class CreateCareNameCommandHandler
    {
        private readonly IRepository<CareName> _repository;

        public CreateCareNameCommandHandler(IRepository<CareName> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCareNameCommand command)
        {
            await _repository.CreateAsync(new CareName
            {
                Care_Name=command.Care_Name,
                Ins_user = command.Ins_user,
                Ins_date = command.Ins_date,
                Is_active = command.Is_active
            });
        }
    }
}
