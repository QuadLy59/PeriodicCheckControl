using PeriodicCheck.Application.Features.CQRS.Command.CareMaterialCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.CareMaterialHandler
{
    public class UpdateCareMaterialCommandHandler
    {
        private readonly IRepository<CareMaterial> _repository;

        public UpdateCareMaterialCommandHandler(IRepository<CareMaterial> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCareMaterialCommand command)
        {
            var values = await _repository.GetByIdAsync(command.CareMaterialId);
            values.CareId = command.CareId;
            values.MaterialId = command.MaterialId;
            values.Updated_user = command.Updated_user;
            values.Updated_date = command.Updated_date;
            values.Is_active = command.Is_active;
            await _repository.UpdateAsync(values);
        }
    }
}
