using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Command.RoleAuthorityCommand
{
    public class UpdateRoleAuthorityCommand
    {
        [Key]
        public int RoleAuthorityId { get; set; }
        public int? RoleId { get; set; }
        public int? AuthorityId { get; set; }
        public int? Updated_user { get; set; }
        public DateTime? Updated_date { get; set; }
        public bool Is_active { get; set; }
    }
}
