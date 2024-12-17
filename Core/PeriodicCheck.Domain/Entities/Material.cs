using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Domain.Entities
{
    public class Material
    {
        [Key]
        public int Material_id { get; set; }
        public string Material_Name { get; set; } 
        public int Care_id { get; set; }
        public Care Care { get; set; }
        public List<CareDetail> CareDetails { get; set; }
        public List<CareReport> CareReports { get; set; }
    }
}
