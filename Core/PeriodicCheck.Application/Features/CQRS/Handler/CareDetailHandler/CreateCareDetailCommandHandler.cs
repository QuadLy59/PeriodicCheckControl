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
    public class CreateCareDetailCommandHandler
    {
        private readonly IRepository<CareDetail> _repository;

        public CreateCareDetailCommandHandler(IRepository<CareDetail> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCareDetailCommand command)
        {
            await _repository.CreateAsync(new CareDetail
            {
                CareId=command.CareId,
                MaterialId=command.MaterialId,
                CareNameId=command.CareNameId,
                Selected_Care=command.Selected_Care,
                Care_Date = command.Care_Date,
                Ins_date =command.Ins_date,
                Ins_user=command.Ins_user,
                Is_active=command.Is_active
            });
        }
    }
}
