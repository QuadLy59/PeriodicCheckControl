using System;
using System.ComponentModel.DataAnnotations;

namespace PeriodicCheck.Application.Features.CQRS.Command.FaultDetailCommand
{
    public class UpdateFaultDetailCommand
    {
        [Key]
        public int FaultDetailId { get; set; }
        public int EquipmentId { get; set; }
        public int CategoryId { get; set; }
        public int FaultId { get; set; }
        public DateTime Report_Date { get; set; }
        public string Report_Person { get; set; }
        public DateTime Solution_Date { get; set; }
        public string Solution_Person { get; set; }
        public int? Updated_user { get; set; }
        public DateTime? Updated_date { get; set; } = DateTime.Now;
        public bool Is_active { get; set; }
    }
}
