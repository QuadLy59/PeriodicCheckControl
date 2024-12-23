using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Command.CareReportCommand
{
    public class UpdateCareReportCommand
    {
        [Key]
        public int CareReportId { get; set; }
        public DateTime CareReportDate { get; set; }
        public int CareId { get; set; }
        public int EquipmentId { get; set; }
        public int CategoryId { get; set; }
        public int MaterialId { get; set; }
        public int? Updated_user { get; set; }
        public DateTime? Updated_date { get; set; }
        public bool Is_active { get; set; }
    }
}
