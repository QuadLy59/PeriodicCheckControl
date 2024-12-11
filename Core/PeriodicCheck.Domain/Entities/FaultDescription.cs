using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Domain.Entities
{
    public  class FaultDescription
    {
        [Key]
        public int FaultDescriptionId { get; set; }
        public int EquipmentId { get; set; }

        [ForeignKey(nameof(EquipmentId))]
        public Equipment Equipment { get; set; }
        public int CategoryId { get; set; } 

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
        public int FaultId { get; set; }  // FaultId'yi ilişkilendirecek
        [ForeignKey(nameof(FaultId))]
        public Fault Fault { get; set; }
        public string Description { get; set; } 
        public string SelectedFault { get; set; }// Dropdown'dan seçilen arızanın kayıt yeri
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
