using System;
using System.ComponentModel.DataAnnotations;

namespace PeriodicCheck.Application.Features.CQRS.Command.StockCommand
{
    public class UpdateStockCommand
    {
        [Key]
        public int StockId { get; set; }
        public int EquipmentId { get; set; }
        public int CategoryId { get; set; }
        public int? Updated_user { get; set; }
        public DateTime? Updated_date { get; set; } = DateTime.Now;
        public bool Is_active { get; set; }
        public bool Is_deleted { get; set; }
    }
}
