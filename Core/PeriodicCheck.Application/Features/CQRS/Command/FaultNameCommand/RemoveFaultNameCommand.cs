using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Command.FaultNameCommand
{
    public class RemoveFaultNameCommand
    {
        public int Id { get; set; }

        public RemoveFaultNameCommand(int ıd)
        {
            Id = ıd;
        }
    }
}
