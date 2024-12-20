using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Command.AuthorityCommand
{
    public class RemoveAuthorityCommand
    {
        public int Id { get; set; }

        public RemoveAuthorityCommand(int id)
        {
            Id = id;
        }
    }
}
