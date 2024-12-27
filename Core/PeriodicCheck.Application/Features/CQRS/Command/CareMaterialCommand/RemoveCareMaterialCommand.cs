using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Command.CareMaterialCommand
{
    public class RemoveCareMaterialCommand
    {
        public int Id { get; set; }

        public RemoveCareMaterialCommand(int id)
        {
            Id = id;
        }
    }
}
