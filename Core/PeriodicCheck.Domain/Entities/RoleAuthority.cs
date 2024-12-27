using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Domain.Entities
{
    public class RoleAuthority
    {
        [Key]
        public int RoleAuthorityId { get; set; }

        public int? RoleId { get; set; }

        public int? AuthorityId { get; set; }
        public Role Role { get; set; }
        public Authority Authority { get; set; }
        public List<User> Users { get; set; }
        public int? Ins_user { get; set; }
        public DateTime? Ins_date { get; set; }
        public int? Updated_user { get; set; }
        public DateTime? Updated_date { get; set; }
        public int? Deleted_user { get; set; }
        public DateTime? Deleted_date { get; set; }
        public bool Is_active { get; set; }
        public bool Is_deleted { get; set; }
    }
}
