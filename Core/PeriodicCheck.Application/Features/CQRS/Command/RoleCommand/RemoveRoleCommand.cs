using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Command.RoleCommand
{
    public class RemoveRoleCommand
    {
        public int Id { get; set; }

        public RemoveRoleCommand(int id)
        {
            Id = id;
        }
    }
}
