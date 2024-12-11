using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Commands.FaultCommands
{
    public class RemoveFaultCommand
    {
        public int Id { get; set; }

        public RemoveFaultCommand(int id)
        {
            Id = id;
        }
    }
}
