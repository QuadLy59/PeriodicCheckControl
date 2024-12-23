using PeriodicCheck.Application.Features.CQRS.Command.CareReportCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.CareReportHandler
{
    public class CreateCareReportCommandHandler
    {
        private readonly IRepository<CareReport> _repository;

        public CreateCareReportCommandHandler(IRepository<CareReport> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCareReportCommand command)
        {
            await _repository.CreateAsync(new CareReport
            {
                CareReportDate = command.CareReportDate,
                CareId = command.CareId,
                EquipmentId = command.EquipmentId,
                CategoryId = command.CategoryId,
                MaterialId = command.MaterialId,
                Ins_user = command.Ins_user,
                Ins_date = command.Ins_date,
                Is_active = command.Is_active,

            });
        }
    }
}
