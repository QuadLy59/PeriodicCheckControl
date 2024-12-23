using PeriodicCheck.Application.Features.CQRS.Command.CareReportCommand;
using PeriodicCheck.Application.Features.CQRS.Command.UserCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.CareReportHandler
{
    public class RemoveCareReportCommandHandler
    {
        private readonly IRepository<CareReport> _repository;

        public RemoveCareReportCommandHandler(IRepository<CareReport> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveCareReportCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }

    }
}
