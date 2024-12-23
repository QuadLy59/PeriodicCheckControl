using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Command.CareDetailCommand
{
    public class CreateCareDetailCommand
    {
        public int CareId { get; set; }
        public int MaterialId { get; set; }
        public string Care_Name { get; set; }
        public string Selected_Care { get; set; }
        public byte Care_Photo { get; set; }
        public int? Ins_user { get; set; }
        public DateTime? Ins_date { get; set; }
        public bool Is_active { get; set; }
    }
}
