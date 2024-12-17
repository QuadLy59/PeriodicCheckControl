using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Domain.Entities
{
    public class Fault
    {
        [Key]
        public int Fault_id { get; set; }
        public string Fault_Name { get; set; }
        public string Selected_Fault { get; set; }
        public string Case { get; set; }
        public int Equipment_id { get; set; }
        public  Equipment Equipment { get; set; }
        public string Fault_description { get; set; }
        public int? Ins_user { get; set; }
        public DateTime? Ins_date { get; set; }
        public int? Updated_user { get; set; }
        public DateTime? Updated_date { get; set; }
        public int? Deleted_user { get; set; }
        public DateTime? Deleted_date { get; set; }
        public bool Is_active { get; set; }
        public bool Is_deleted { get; set; }
        public List<FaultDetail> FaultDescriptions { get; set; } 
    }
}
