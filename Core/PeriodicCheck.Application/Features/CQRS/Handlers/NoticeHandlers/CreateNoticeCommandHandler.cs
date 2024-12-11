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
    public class CreateNoticeCommandHandler
    {
        private readonly IRepository<Notice> _repository;

        public CreateNoticeCommandHandler(IRepository<Notice> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateNoticeCommand command)
        {
            await _repository.CreateAsync(new Notice
            {
                Equipment_id = command.Equipment_id,
                Notice_date = command.Notice_date,
                Notice_type = command.Notice_type,
                Ins_date = command.Ins_date,
                Ins_user = command.Ins_user,
                Is_active = command.Is_active,
                İncharge_mail= command.İncharge_mail
            });
        }
    }
}
