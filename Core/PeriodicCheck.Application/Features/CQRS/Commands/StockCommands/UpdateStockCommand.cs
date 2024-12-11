using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Commands.StockCommands
{
    public class UpdateStockCommand
    {
        [Key]
        public int Stock_id { get; set; }
        public int Equipment_id { get; set; }
        public int Quantity { get; set; }
        public string Location { get; set; }
        public string Situtation { get; set; }
        public int? Updated_user { get; set; }
        public DateTime? Updated_date { get; set; }
        public bool Is_active { get; set; }
        public bool Is_deleted { get; set; }
    }
}
