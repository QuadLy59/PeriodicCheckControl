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
    public class UpdateFaultCommandHandler
    {
        private readonly IRepository<Fault> _repository;

        public UpdateFaultCommandHandler(IRepository<Fault> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateFaultCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Fault_id);
            values.Fault_id = command.Fault_id;
            values.Fault_description = command.Fault_description;
            values.Report_date = command.Report_date;
            values.Report_person = command.Report_person;
            values.Updated_date = command.Updated_date;
            values.Updated_user = command.Updated_user;
            values.Case = command.Case;
            values.Is_active = command.Is_active;
            values.Equipment_id = command.Equipment_id;
            values.Solution_date = command.Solution_date;
            values.Solution_person = command.Solution_person;
            await _repository.UpdateAsync(values);

        }
    }
}
