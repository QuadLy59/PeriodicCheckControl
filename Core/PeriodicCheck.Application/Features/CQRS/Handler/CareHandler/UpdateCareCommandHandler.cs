using PeriodicCheck.Application.Features.CQRS.Command.CareCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.CareHandler
{
    public class UpdateCareCommandHandler
    {
        private readonly IRepository<Care> _repository;

        public UpdateCareCommandHandler(IRepository<Care> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCareCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Care_id);
            values.EquipmentId=command.Equipment_id;

            values.Technician = command.Technician;
            values.Next_Care_Date= command.Next_Care_Date;
            values.Previ_Care_Date = command.Previ_Care_Date;
            values.Control_Type = command.Control_Type;
            values.Care_Description = command.Care_Description;
            values.Care_Photo = command.Care_Photo;
            values.Ins_date = command.Ins_date;
            values.Ins_user = command.Ins_user;
            values.Deleted_date=command.Deleted_date;
            values.Deleted_user = command.Deleted_user;
            values.Updated_date =command.Updated_date;
            values.Updated_user = command.Updated_user;
            values.Is_active = command.Is_active;
            values.Is_deleted = command.Is_deleted;
            await _repository.UpdateAsync(values);

        }
    }
}
