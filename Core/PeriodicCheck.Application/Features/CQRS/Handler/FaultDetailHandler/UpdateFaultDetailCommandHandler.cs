﻿using PeriodicCheck.Application.Features.CQRS.Command.FaultDetailCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.FaultDetailHandler
{
    public class UpdateFaultDetailCommandHandler
    {
        private readonly IRepository<FaultDetail> _repository;

        public UpdateFaultDetailCommandHandler(IRepository<FaultDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFaultDetailCommand command)
        {
            var values = await _repository.GetByIdAsync(command.FaultDetailId);
            values.EquipmentId = command.EquipmentId;
            values.FaultId = command.FaultId;

            values.Updated_user = command.Updated_user;
            values.Updated_date = command.Updated_date;
            values.Is_active = command.Is_active;
            await _repository.UpdateAsync(values);
        }
    }
}
