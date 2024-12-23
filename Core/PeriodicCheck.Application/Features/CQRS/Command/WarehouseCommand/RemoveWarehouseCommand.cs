using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Command.WarehouseCommand
{
    public class RemoveWarehouseCommand
    {
        public int Id { get; set; }

        public RemoveWarehouseCommand(int id)
        {
            Id = id;
        }
    }
}
