using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Command.CareReportCommand
{
    public class RemoveCareReportCommand
    {
        public int Id { get; set; }

        public RemoveCareReportCommand(int id)
        {
            Id = id;
        }
    }
}
