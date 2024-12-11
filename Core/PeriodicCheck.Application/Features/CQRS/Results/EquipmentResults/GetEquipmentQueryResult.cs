using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Results.EquipmentResults
{
    public class GetEquipmentQueryResult
    {
        [Key]
        public int Equipment_id { get; set; }
        public string Equipment_name { get; set; }
        public string Serial_no { get; set; }
        public string Company { get; set; }
        public int Warehouse_id { get; set; }
        public string Responsible { get; set; }
        public string Communication { get; set; }
        public int Category_id { get; set; }
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
