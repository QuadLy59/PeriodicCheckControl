using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveySystem.Application.Features.CQRS.Commands.RoleCommands
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
