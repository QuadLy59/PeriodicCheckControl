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
    public class UpdateCareNameCommandHandler
    {
        private readonly IRepository<CareName> _repository;

        public UpdateCareNameCommandHandler(IRepository<CareName> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCareNameCommand command)
        {
            var values = await _repository.GetByIdAsync(command.CareNameId);
            values.Care_Name = command.Care_Name;
            values.Updated_user = command.Updated_user;
            values.Updated_date = command.Updated_date;
            values.Is_active = command.Is_active;
            await _repository.UpdateAsync(values);
        }
    }
}
