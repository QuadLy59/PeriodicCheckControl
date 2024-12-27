using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Command.CareNameCommand
{
    public class RemoveCareNameCommand
    {
        public int Id { get; set; }

        public RemoveCareNameCommand(int id)
        {
            Id = id;
        }
    }
}
