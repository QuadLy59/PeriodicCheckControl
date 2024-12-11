using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Commands.CareCommands
{
    public class CreateCareCommand
    {
        [Key]
        public int Equipment_id { get; set; }
        public DateTime Care_date { get; set; }
        public string Techinician { get; set; }
        public string Care_report { get; set; }
        public DateTime next_care { get; set; }
        public int? Ins_user { get; set; }
        public DateTime? Ins_date { get; set; }
        public bool Is_active { get; set; }
    }
}
