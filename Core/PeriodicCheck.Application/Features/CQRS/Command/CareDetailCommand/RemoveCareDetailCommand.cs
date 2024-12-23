using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Command.CareDetailCommand
{
    public class RemoveCareDetailCommand
    {
        public int Id { get; set; }

        public RemoveCareDetailCommand(int id)
        {
            Id = id;
        }
    }
}
