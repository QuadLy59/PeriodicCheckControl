using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Command.CategoryCommand
{
    public class CreateCategoryCommand
    {
        public string CategoryName { get; set; }
        public int EquipmentId { get; set; }
        public int CareId { get; set; }
        public int? Ins_user { get; set; }
        public DateTime? Ins_date { get; set; }
        public bool Is_active { get; set; }
    }
}
