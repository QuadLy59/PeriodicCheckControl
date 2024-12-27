using System;

namespace PeriodicCheck.Application.Features.CQRS.Command.FaultDetailCommand
{
    public class CreateFaultDetailCommand
    {
        public int? EquipmentId { get; set; }
        public int? FaultId { get; set; }

        public int Ins_user { get; set; }
        public DateTime Ins_date { get; set; } = DateTime.Now;
        public bool Is_active { get; set; }
    }
}
