using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Domain.Entities
{
    public class Material
    {
        [Key]
        public int MaterialId { get; set; }
        public string Material_Name { get; set; }
  
        public int? CareId { get; set; }
        public Care Care { get; set; }
    
        public int? EquipmentId { get; set; }
        public Equipment Equipment { get; set; }
        public int? Ins_user { get; set; }
        public DateTime? Ins_date { get; set; }
        public int? Updated_user { get; set; }
        public DateTime? Updated_date { get; set; }
        public int? Deleted_user { get; set; }
        public DateTime? Deleted_date { get; set; }
        public bool Is_active { get; set; }
        public bool Is_deleted { get; set; }
        public List<CareDetail> CareDetails { get; set; }
        public List<CareMaterial> CareMaterials { get; set; } 
    }
}
