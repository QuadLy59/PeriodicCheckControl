using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Command.UserCommand
{
    public class UpdateUserCommand
    {
        [Key]
        public int UserId { get; set; }
        public int? RoleId { get; set; }
        public string Name_And_Surname { get; set; }
        public int Phone_Number { get; set; }
        public string Email { get; set; }
        public byte Password { get; set; }
        public int? Updated_user { get; set; }
        public DateTime? Updated_date { get; set; } = DateTime.Now;
        public bool Is_active { get; set; }
 
    }
}
