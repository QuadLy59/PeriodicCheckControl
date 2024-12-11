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
    public class CreatePeriodicActivityStatusCommandHandler
    {
        private readonly IRepository<PeriodicActivityStatus> _repository;

        public CreatePeriodicActivityStatusCommandHandler(IRepository<PeriodicActivityStatus> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreatePeriodicActivityStatusCommand command)
        {
            await _repository.CreateAsync(new PeriodicActivityStatus
            {
                Equipment_id = command.Equipment_id,
                ActivityDate = command.ActivityDate,
                ActivityType = command.ActivityType,
                Description = command.Description,
                Fault_description = command.Fault_description,
                Report_date = command.Report_date,
                Report_person = command.Report_person,
                Solution_date = command.Solution_date,
                Solution_person = command.Solution_person,
                İncharge_mail = command.İncharge_mail,
                Care_date = command.Care_date,
                Techinician = command.Techinician,
                Care_report = command.Care_report,
                next_care = command.next_care,
                Quantity = command.Quantity,
                Situtation = command.Situtation,
                Notice_type = command.Notice_type,
                Notice_date = command.Notice_date,
                Ins_date = command.Ins_date,
                Ins_user = command.Ins_user,
                Is_active = command.Is_active,
            });
        }
    }
}
