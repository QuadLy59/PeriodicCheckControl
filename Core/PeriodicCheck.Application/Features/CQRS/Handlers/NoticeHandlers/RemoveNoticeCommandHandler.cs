using PeriodicCheck.Application.Features.CQRS.Commands.NoticeCommands;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handlers.NoticeHandlers
{
    public class RemoveNoticeCommandHandler
    {
        private readonly IRepository<Notice> _repository;

        public RemoveNoticeCommandHandler(IRepository<Notice> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveNoticeCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
