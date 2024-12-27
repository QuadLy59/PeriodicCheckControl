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
    public class UpdateCareDetailCommandHandler
    {
        private readonly IRepository<CareDetail> _repository;

        public UpdateCareDetailCommandHandler(IRepository<CareDetail> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCareDetailCommand command)
        {
            var values = await _repository.GetByIdAsync(command.CareDetailId);
            values.CareId = command.CareId;
            values.MaterialId = command.MaterialId;
            values.CareNameId = command.CareNameId;
            values.Selected_Care = command.Selected_Care;
            values.Care_Date = command.Care_Date;
            values.Updated_user = command.Updated_user;
            values.Updated_date = command.Updated_date;
            values.Is_active = command.Is_active;
            await _repository.UpdateAsync(values);

        }
    }
}
