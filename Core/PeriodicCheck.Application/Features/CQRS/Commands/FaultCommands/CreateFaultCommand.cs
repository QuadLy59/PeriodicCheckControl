using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Commands.FaultCommands
{
    public class CreateFaultCommand
    {
        [Key]
        public int Equipment_id { get; set; }
        public string Fault_description { get; set; }
        public DateTime Report_date { get; set; }
        public string Report_person { get; set; }
        public string Case { get; set; }
        public DateTime Solution_date { get; set; }
        public string Solution_person { get; set; }
        public int? Ins_user { get; set; }
        public DateTime? Ins_date { get; set; }
        public bool Is_active { get; set; }
        public bool Is_deleted { get; set; }
    }
}
