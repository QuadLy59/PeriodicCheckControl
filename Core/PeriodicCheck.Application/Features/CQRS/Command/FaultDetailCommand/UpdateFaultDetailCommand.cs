using System;
using System.ComponentModel.DataAnnotations;

namespace PeriodicCheck.Application.Features.CQRS.Command.FaultDetailCommand
{
    public class UpdateFaultDetailCommand
    {
        [Key]
        public int FaultDetailId { get; set; }
        public int? EquipmentId { get; set; }
        public int? FaultId { get; set; }

        public int? Updated_user { get; set; }
        public DateTime? Updated_date { get; set; } = DateTime.Now;
        public bool Is_active { get; set; }
    }
}
