using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveySystem.Application.Features.CQRS.Commands.RoleCommands
{
    public class CreateRoleCommand
    {
        public string Role_Name { get; set; }
        public string Description { get; set; }
        public int Ins_user { get; set; }
        public DateTime Ins_date { get; set; } = DateTime.Now;
        public bool Is_active { get; set; } = true;
    }
}
