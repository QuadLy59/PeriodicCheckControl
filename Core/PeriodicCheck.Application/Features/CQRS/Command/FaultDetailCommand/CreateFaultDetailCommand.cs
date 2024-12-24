using System;

namespace PeriodicCheck.Application.Features.CQRS.Command.FaultDetailCommand
{
    public class CreateFaultDetailCommand
    {
        public int EquipmentId { get; set; }
        public int CategoryId { get; set; }
        public int FaultId { get; set; }
        public DateTime Report_Date { get; set; }
        public string Report_Person { get; set; }
        public DateTime Solution_Date { get; set; }
        public string Solution_Person { get; set; }
        public int Ins_user { get; set; }
        public DateTime Ins_date { get; set; } = DateTime.Now;
        public bool Is_active { get; set; }
    }
}
