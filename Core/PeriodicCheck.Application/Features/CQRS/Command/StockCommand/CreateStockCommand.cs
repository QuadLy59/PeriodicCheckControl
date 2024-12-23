using System;

namespace PeriodicCheck.Application.Features.CQRS.Command.StockCommand
{
    public class CreateStockCommand
    {
        public int EquipmentId { get; set; }
        public int CategoryId { get; set; }
        public int Ins_user { get; set; }
        public DateTime Ins_date { get; set; } = DateTime.Now;
        public bool Is_active { get; set; }
    }
}
