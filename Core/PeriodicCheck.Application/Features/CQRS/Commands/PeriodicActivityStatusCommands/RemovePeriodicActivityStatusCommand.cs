using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Commands.PeriodicActivityStatusCommands
{
    public class RemovePeriodicActivityStatusCommand
    {
        public int Id { get; set; }

        public RemovePeriodicActivityStatusCommand(int id)
        {
            Id = id;
        }
    }
}
