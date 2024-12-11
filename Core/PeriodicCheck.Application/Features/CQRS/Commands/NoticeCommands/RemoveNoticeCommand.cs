using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Commands.NoticeCommands
{
    public class RemoveNoticeCommand
    {
        public int Id { get; set; }

        public RemoveNoticeCommand(int id)
        {
            Id = id;
        }
    }
}
