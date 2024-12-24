using System;
using System.ComponentModel.DataAnnotations;

namespace PeriodicCheck.Application.Features.CQRS.Command.FaultCommand
{
    public class UpdateFaultCommand
    {
        [Key]
        public int FaultId { get; set; }
        public string Fault_Name { get; set; }
        public string Selected_Fault { get; set; }
        public string Case { get; set; }
        public int EquipmentId { get; set; }
        public string Fault_Description { get; set; }
        public int? Updated_user { get; set; }
        public DateTime? Updated_date { get; set; } = DateTime.Now;
        public bool Is_active { get; set; }
    }
}
