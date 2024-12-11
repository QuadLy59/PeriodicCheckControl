using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Commands.CareCommands
{
    public class RemoveCareCommand
    {
        public int Id { get; set; }

        public RemoveCareCommand(int id)
        {
            Id = id;
        }
    }
}
