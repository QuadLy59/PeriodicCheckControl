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
    public class CreateCareCommandHandler
    {
        private readonly IRepository<Care> _repository;

        public CreateCareCommandHandler(IRepository<Care> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCareCommand command)
        {
            await _repository.CreateAsync(new Care
            {
                Equipment_id = command.Equipment_id,
                Care_date =command.Care_date,
                Care_report=command.Care_report,         
                Techinician=command.Techinician,
                next_care=command.next_care,
                Ins_date=command.Ins_date,
                Ins_user=command.Ins_user,
                Is_active=command.Is_active,
            });
        }
    }
}
