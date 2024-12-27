using System;
using System.ComponentModel.DataAnnotations;

namespace PeriodicCheck.Application.Features.CQRS.Results.FaultResults
{
    public class GetFaultQueryResult
    {
        [Key]
        public int FaultId { get; set; }
        public string Selected_Fault { get; set; }
        public string Case { get; set; }
        public string Fault_Description { get; set; }
        public DateTime Report_Date { get; set; }
        public string Report_Person { get; set; }
        public DateTime Solution_Date { get; set; }
        public string Solution_Person { get; set; }

        public int? Ins_user { get; set; }
        public DateTime? Ins_date { get; set; }

        public int? Updated_user { get; set; }
        public DateTime? Updated_date { get; set; }

        public int? Deleted_user { get; set; }
        public DateTime? Deleted_date { get; set; }

        public bool? Is_active { get; set; }
        public bool? Is_deleted { get; set; }
    }
}
