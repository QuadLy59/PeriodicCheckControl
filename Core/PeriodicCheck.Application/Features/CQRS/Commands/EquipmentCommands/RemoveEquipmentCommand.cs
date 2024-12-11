using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Commands.EquipmentCommands
{
    public class RemoveEquipmentCommand
    {
        public int Id { get; set; }

        public RemoveEquipmentCommand(int id)
        {
            Id = id;
        }
    }
}
