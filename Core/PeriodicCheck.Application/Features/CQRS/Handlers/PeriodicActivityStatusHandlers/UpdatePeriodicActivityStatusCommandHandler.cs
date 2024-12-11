using PeriodicCheck.Application.Features.CQRS.Commands.PeriodicActivityStatusCommands;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handlers.PeriodicActivityStatusHandlers
{
    public class UpdatePeriodicActivityStatusCommandHandler
    {
        private readonly IRepository<PeriodicActivityStatus> _repository;

        public UpdatePeriodicActivityStatusCommandHandler(IRepository<PeriodicActivityStatus> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdatePeriodicActivityStatusCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Activity_id);
            values.Solution_date = command.Solution_date;
            values.Report_date = command.Report_date;
            values.Care_date = command.Care_date;
            values.Updated_date = command.Updated_date;
            values.Updated_user = command.Updated_user;
            values.ActivityDate = command.ActivityDate;
            values.ActivityType = command.ActivityType;
            values.Situtation= command.Situtation;
            values.Solution_person = command.Solution_person;
            values.Quantity = command.Quantity;
            values.Care_report = command.Care_report;
            values.Equipment_id = command.Equipment_id;
            values.Fault_description = command.Fault_description;
            values.Description = command.Description;
            values.Is_active = command.Is_active;
            values.next_care = command.next_care;
            values.Notice_date = command.Notice_date;
            values.Notice_type = command.Notice_type;
            values.Report_person = command.Report_person;
            values.İncharge_mail = command.İncharge_mail;
            values.Techinician= command.Techinician;
            await _repository.UpdateAsync(values);
        }
    }
}
