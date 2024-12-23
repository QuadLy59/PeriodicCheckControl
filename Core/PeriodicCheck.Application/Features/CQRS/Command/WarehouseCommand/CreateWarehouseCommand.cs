using System;

namespace PeriodicCheck.Application.Features.CQRS.Command.WarehouseCommand
{
    public class CreateWarehouseCommand
    {
        public string Warehouse_Name { get; set; }
        public int EquipmentId { get; set; }
        public int? Ins_user { get; set; }
        public DateTime? Ins_date { get; set; }
        public int? Updated_user { get; set; }
        public DateTime? Updated_date { get; set; }
        public int? Deleted_user { get; set; }
        public DateTime? Deleted_date { get; set; }
        public bool Is_active { get; set; }
        public bool Is_deleted { get; set; }
    }
}
