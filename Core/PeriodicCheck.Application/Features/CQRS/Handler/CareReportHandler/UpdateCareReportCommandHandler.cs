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
    public class UpdateCareReportCommandHandler
    {
        private readonly IRepository<CareReport> _repository;

        public UpdateCareReportCommandHandler(IRepository<CareReport> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCareReportCommand command)
        {
           var values = await _repository.GetByIdAsync(command.CareReportId);
            values.CareReportDate = command.CareReportDate;
            values.CareId = command.CareId;
            values.EquipmentId = command.EquipmentId;
            values.CategoryId = command.CategoryId;
            values.MaterialId = command.MaterialId;
            values.Updated_user = command.Updated_user;
            values.Updated_date = command.Updated_date;
            values.Is_active = command.Is_active;
            await _repository.UpdateAsync(values);


        }
    } 
}

