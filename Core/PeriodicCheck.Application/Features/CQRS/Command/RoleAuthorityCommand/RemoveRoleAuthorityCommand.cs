using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Command.RoleAuthorityCommand
{
    public class RemoveRoleAuthorityCommand
    {
        public int Id { get; set; }

        public RemoveRoleAuthorityCommand(int id)
        {
            Id = id;
        }
    }
}
