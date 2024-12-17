
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Domain.Entities
{
    public class CareReport
    {
        [Key]
        public int Care_Report_id { get; set; }
        public DateTime Care_Report_Date { get; set; }
        public int Care_id { get; set; }
        public int Equipment_id { get; set; }
        public int Category_id { get; set; } 
        public int? Ins_user { get; set; }
        public DateTime? Ins_date { get; set; }
        public int? Updated_user { get; set; }
        public DateTime? Updated_date { get; set; }
        public int? Deleted_user { get; set; }
        public DateTime? Deleted_date { get; set; }
        public bool Is_active { get; set; }
        public bool Is_deleted { get; set; }
        public Care Care { get; set; }
        public Equipment Equipment { get; set; }
        public Category Category { get; set; }
        public Material Material { get; set; }

    }
}
