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
    public class CreateCareMaterialCommandHandler
    {
        private readonly IRepository<CareMaterial> _repository;

        public CreateCareMaterialCommandHandler(IRepository<CareMaterial> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCareMaterialCommand command)
        {
            await _repository.CreateAsync(new CareMaterial
            {
                CareId = command.CareId,
                MaterialId = command.MaterialId,
                Ins_user = command.Ins_user,
                Ins_date = command.Ins_date,
                Is_active = command.Is_active
            });
        }
    }
}
