using System;

namespace PeriodicCheck.Application.Features.CQRS.Command.FaultCommand
{
    public class CreateFaultCommand
    {
        public string Selected_Fault { get; set; }
        public DateTime Report_Date { get; set; }
        public string Report_Person { get; set; }
        public DateTime Solution_Date { get; set; }
        public string Solution_Person { get; set; }
        public string Case { get; set; }
        public string Fault_Description { get; set; }
        public int Ins_user { get; set; }
        public DateTime Ins_date { get; set; } = DateTime.Now;
        public bool Is_active { get; set; }
    }
}
