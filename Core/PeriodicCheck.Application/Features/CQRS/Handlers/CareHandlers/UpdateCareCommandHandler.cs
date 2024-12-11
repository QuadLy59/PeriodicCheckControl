using PeriodicCheck.Application.Features.CQRS.Commands.CareCommands;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handlers.CareHandlers
{
    public class UpdateCareCommandHandler
    {
        private readonly IRepository<Care> _repository;

        public UpdateCareCommandHandler(IRepository<Care> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCareCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Care_id);
            values.next_care = command.next_care;
            values.Care_date = command.Care_date;
            values.Care_report = command.Care_report;
            values.Updated_date = command.Updated_date;
            values.Techinician = command.Techinician;
            values.Updated_user = command.Updated_user;
            values.Equipment_id = command.Equipment_id;
            values.Is_active = command.Is_active;
            await _repository.UpdateAsync(values);
        }
    }
}
