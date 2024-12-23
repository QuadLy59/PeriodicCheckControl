using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Results.CareDetailResults
{
    public class GetCareDetailQueryResult
    {
        [Key]
        public int Care_DetailId { get; set; }
        public int CareId { get; set; }
        public int MaterialId { get; set; }
        public string Care_Name { get; set; }
        public string Selected_Care { get; set; }
        public byte Care_Photo { get; set; }
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
