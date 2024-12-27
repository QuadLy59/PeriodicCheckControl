using PeriodicCheck.Application.Features.CQRS.Command.FaultNameCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.FaultNameHandler
{
    public class CreateFaultNameCommandHandler
    {
        private readonly IRepository<FaultName> _repository;

        public CreateFaultNameCommandHandler(IRepository<FaultName> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateFaultNameCommand command)
        {
            await _repository.CreateAsync(new FaultName
            {
                Fault_Name=command.Fault_Name,
                Ins_user = command.Ins_user,
                Ins_date = command.Ins_date,
                Is_active = command.Is_active
            });
        }
    }
}
