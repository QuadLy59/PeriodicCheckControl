using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Domain.Entities
{
    public class Notice
    {
        [Key]
        public int Notice_id { get; set; }
        public int Equipment_id { get; set; }
        public Equipment Equipment { get; set; }
        public string Notice_type { get; set; }
        public DateTime Notice_date { get; set; }
        
        [EmailAddress]
        public string İncharge_mail { get; set; }
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
