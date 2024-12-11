using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Commands.StockCommands
{
    public class RemoveStockCommand
    {
        public int Id { get; set; }

        public RemoveStockCommand(int id)
        {
            Id = id;
        }
    }
}
