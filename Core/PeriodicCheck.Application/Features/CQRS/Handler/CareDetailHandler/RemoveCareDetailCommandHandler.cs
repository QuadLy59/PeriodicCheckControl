using PeriodicCheck.Application.Features.CQRS.Command.CareDetailCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.CareDetailHandler
{
    public class RemoveCareDetailCommandHandler
    {
        private readonly IRepository<CareDetail> _repository;

        public RemoveCareDetailCommandHandler(IRepository<CareDetail> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveCareDetailCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
