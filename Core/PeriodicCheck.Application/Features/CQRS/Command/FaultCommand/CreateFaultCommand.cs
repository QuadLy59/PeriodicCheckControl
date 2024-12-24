using System;

namespace PeriodicCheck.Application.Features.CQRS.Command.FaultCommand
{
    public class CreateFaultCommand
    {
        public string Fault_Name { get; set; }
        public string Selected_Fault { get; set; }
        public string Case { get; set; }
        public int EquipmentId { get; set; }
        public string Fault_Description { get; set; }
        public int Ins_user { get; set; }
        public DateTime Ins_date { get; set; } = DateTime.Now;
        public bool Is_active { get; set; }
    }
}
