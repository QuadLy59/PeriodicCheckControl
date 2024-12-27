﻿using PeriodicCheck.Application.Features.CQRS.Command.CareMaterialCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.CareMaterialHandler
{
    public class RemoveCareMaterialCommandHandler
    {
        private readonly IRepository<CareMaterial> _repository;

        public RemoveCareMaterialCommandHandler(IRepository<CareMaterial> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveCareMaterialCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
