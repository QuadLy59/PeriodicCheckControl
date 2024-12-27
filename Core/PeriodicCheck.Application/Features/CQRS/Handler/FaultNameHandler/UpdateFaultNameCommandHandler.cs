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
    public class UpdateFaultNameCommandHandler
    {
        private readonly IRepository<FaultName> _repository;

        public UpdateFaultNameCommandHandler(IRepository<FaultName> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateFaultNameCommand command)
        {
            var values = await _repository.GetByIdAsync(command.FaultNameId);
            values.Fault_Name = command.Fault_Name;
            values.Updated_user = command.Updated_user;
            values.Updated_date = command.Updated_date;
            values.Is_active = command.Is_active;
            await _repository.UpdateAsync(values);
        } 
    }
}
