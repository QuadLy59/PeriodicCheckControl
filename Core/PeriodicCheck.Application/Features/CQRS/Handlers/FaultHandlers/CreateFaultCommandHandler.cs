using PeriodicCheck.Application.Features.CQRS.Commands.FaultCommands;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handlers.FaultHandlers
{
    public class CreateFaultCommandHandler
    {
        private readonly IRepository<Fault> _repository;

        public CreateFaultCommandHandler(IRepository<Fault> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateFaultCommand command)
        {
            await _repository.CreateAsync(new Fault
            {
                Equipment_id = command.Equipment_id,
                Case = command.Case,
                Fault_description = command.Fault_description,
                Ins_date = command.Ins_date,
                Ins_user = command.Ins_user,
                Is_active = command.Is_active,
                Report_date = command.Report_date,
                Report_person = command.Report_person,
                Solution_date = command.Solution_date,
                Solution_person = command.Solution_person,
                
            });
        }
    }
}
