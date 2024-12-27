using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Command.EquipmentCommand
{
    public class UpdateEquipmentCommand
    {
        [Key]
        public int EquipmentId { get; set; }
        public string Equipment_Name { get; set; }
        public string Serial_No { get; set; }
        public string Company { get; set; }
        public int? WarehouseId { get; set; }
        public string Responsible { get; set; }
        public string Responsible_Communication { get; set; }
        public bool Shift_Turn { get; set; }
        public int? CategoryId { get; set; }
        public int? CareId { get; set; }
        public int? StockId { get; set; }
        public int? FaultId { get; set; }
        public int? Updated_user { get; set; }
        public DateTime? Updated_date { get; set; }
        public bool Is_active { get; set; }
    }
}
