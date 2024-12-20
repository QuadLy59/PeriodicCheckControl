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
    public class CreateCareCommandHandler
    {
        private readonly IRepository<Care> _repository;

        public CreateCareCommandHandler(IRepository<Care> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCareCommand command)
        {
            await _repository.CreateAsync(new Care
            {
                EquipmentId= command.Equipment_id,
                Care_Date=command.Care_Date,
                Technician=command.Technician,
                Next_Care_Date=command.Next_Care_Date,
                Previ_Care_Date=command.Previ_Care_Date,
                Control_Type=command.Control_Type,
                Care_Description=command.Care_Description,
                Ins_date=command.Ins_date,
                Ins_user=command.Ins_user,
                Updated_date=command.Updated_date,
                Updated_user=command.Updated_user,
                Deleted_date=command.Deleted_date,
                Deleted_user=command.Deleted_user,
                Is_active=command.Is_active,
                Is_deleted=command.Is_deleted
            });
        }
    }
}
