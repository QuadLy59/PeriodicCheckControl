using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Command.UserCommand
{
    public class CreateUserCommand
    {
        public int? RoleId { get; set; }
        public string Name_And_Surname { get; set; }
        public int Phone_Number { get; set; }
        public string Email { get; set; }
        public byte Password { get; set; }
        public int Ins_user { get; set; }
        public DateTime Ins_date { get; set; } = DateTime.Now;
        public bool Is_active { get; set; } = true;

    }
}
