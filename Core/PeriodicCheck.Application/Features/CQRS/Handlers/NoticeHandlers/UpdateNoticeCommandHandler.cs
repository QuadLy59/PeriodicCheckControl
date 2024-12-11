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
    public class UpdateNoticeCommandHandler
    {
        private readonly IRepository<Notice> _repository;

        public UpdateNoticeCommandHandler(IRepository<Notice> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateNoticeCommand command)
        {
            var values =await _repository.GetByIdAsync(command.Notice_id);
            values.Updated_date = command.Updated_date; 
            values.Updated_user = command.Updated_user;
            values.Notice_date = command.Notice_date;
            values.Notice_type = command.Notice_type;
            values.Equipment_id = command.Equipment_id;
            values.Is_active = command.Is_active;
            values.İncharge_mail=command.İncharge_mail;
            await _repository.UpdateAsync(values);
        }
    }
}
