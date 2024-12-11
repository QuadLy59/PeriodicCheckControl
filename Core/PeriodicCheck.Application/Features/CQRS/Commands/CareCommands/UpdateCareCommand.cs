using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Commands.CareCommands
{
    public class UpdateCareCommand
    {
        [Key]
        public int Care_id { get; set; }
        public int Equipment_id { get; set; }
        public DateTime Care_date { get; set; }
        public string Techinician { get; set; }
        public string Care_report { get; set; }
        public DateTime next_care { get; set; }
        public int? Updated_user { get; set; }
        public DateTime? Updated_date { get; set; }
        public bool Is_active { get; set; }
    }
}
