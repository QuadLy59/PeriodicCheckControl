using System;
using System.ComponentModel.DataAnnotations;

namespace PeriodicCheck.Application.Features.CQRS.Command.FaultCommand
{
    public class UpdateFaultCommand
    {
        [Key]
        public int FaultId { get; set; }
        public string Selected_Fault { get; set; }
        public DateTime Report_Date { get; set; }
        public string Report_Person { get; set; }
        public DateTime Solution_Date { get; set; }
        public string Solution_Person { get; set; }
        public string Case { get; set; }
        public string Fault_Description { get; set; }
        public int? Updated_user { get; set; }
        public DateTime? Updated_date { get; set; } = DateTime.Now;
        public bool Is_active { get; set; }
    }
}
