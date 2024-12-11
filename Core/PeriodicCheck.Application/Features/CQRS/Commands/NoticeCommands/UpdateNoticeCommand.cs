using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Commands.NoticeCommands
{
    public class UpdateNoticeCommand
    {
        [Key]
        public int Notice_id { get; set; }
        public int Equipment_id { get; set; }
        public string Notice_type { get; set; }
        public DateTime Notice_date { get; set; }

        [EmailAddress]
        public string İncharge_mail { get; set; }
        public int? Updated_user { get; set; }
        public DateTime? Updated_date { get; set; }
        public bool Is_active { get; set; }
        public bool Is_deleted { get; set; }
    }
}
