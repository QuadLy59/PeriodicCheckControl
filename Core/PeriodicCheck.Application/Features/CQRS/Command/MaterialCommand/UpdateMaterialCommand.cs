using System;
using System.ComponentModel.DataAnnotations;

namespace PeriodicCheck.Application.Features.CQRS.Command.MaterialCommand
{
    public class UpdateMaterialCommand
    {
        [Key]
        public int MaterialId { get; set; }
        public string Material_Name { get; set; }
        public int? CareId { get; set; }
        public int? EquipmentId { get; set; }
        public int? Updated_user { get; set; }
        public DateTime? Updated_date { get; set; } = DateTime.Now;
        public bool Is_active { get; set; }
    }
}
