
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
        public int CareReportId { get; set; }
        public int EquipmentId { get; set; }
        [ForeignKey(nameof(EquipmentId))]
        public Equipment Equipment { get; set; } 
        public int CategoryId { get; set; } 

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } 
        public string Description { get; set; } 
        public string SelectedCare { get; set; } // Dropdown'dan seçilen bakımın kayıt yeri
        public DateTime PreviousCareDate { get; set; } 
        public DateTime NextCareDate { get; set; }
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
