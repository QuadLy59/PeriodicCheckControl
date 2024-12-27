using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Command.FaultNameCommand
{
    public class UpdateFaultNameCommand
    {
        [Key]
        public int FaultNameId { get; set; }
        public string Fault_Name { get; set; }
        public int? Updated_user { get; set; }
        public DateTime? Updated_date { get; set; }
        public bool Is_active { get; set; }
    }
}
