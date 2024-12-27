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
    public class RemoveCareNameCommandHandler
    {
        private readonly IRepository<CareName> _repository;

        public RemoveCareNameCommandHandler(IRepository<CareName> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveCareNameCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
