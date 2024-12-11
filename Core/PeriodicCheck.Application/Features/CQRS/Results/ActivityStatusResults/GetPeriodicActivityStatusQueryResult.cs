using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Results.ActivityStatusResults
{
    public class GetPeriodicActivityStatusQueryResult
    {
        [Key]
        public int Activity_id { get; set; }
        public int Equipment_id { get; set; }
        public Equipment Equipment { get; set; }
        public string ActivityType { get; set; }//Türü:Arıza Bakım Stok güncelleme
        public string Description { get; set; }
        public DateTime ActivityDate { get; set; }
        public string Fault_description { get; set; }
        public DateTime Report_date { get; set; }
        public string Report_person { get; set; }
        public DateTime Solution_date { get; set; }
        public string Solution_person { get; set; }
        [EmailAddress]
        public string İncharge_mail { get; set; }
        public DateTime Care_date { get; set; }
        public string Techinician { get; set; }
        public string Care_report { get; set; }
        public DateTime next_care { get; set; }
        public int Quantity { get; set; }
        public string Situtation { get; set; }//Durum Beklemede Bakımda vb.
        public string Notice_type { get; set; }
        public DateTime Notice_date { get; set; }
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
