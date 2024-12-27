using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Command.RoleAuthorityCommand
{
    public class CreateRoleAuthorityCommand
    {
        public int? RoleId { get; set; }
        public int? AuthorityId { get; set; }
        public int? Ins_user { get; set; }
        public DateTime? Ins_date { get; set; }
        public bool Is_active { get; set; }
    }
}
