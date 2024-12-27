using System;

namespace PeriodicCheck.Application.Features.CQRS.Command.MaterialCommand
{
    public class CreateMaterialCommand
    {
        public string Material_Name { get; set; }
        public int? CareId { get; set; }
        public int? EquipmentId { get; set; }
        public int Ins_user { get; set; }
        public DateTime Ins_date { get; set; } = DateTime.Now;
        public bool Is_active { get; set; }
    }
}
