using System;
using System.ComponentModel.DataAnnotations;

namespace PeriodicCheck.Application.Features.CQRS.Results.FaultResults
{
    public class GetFaultByIdQueryResult
    {
        [Key]
        public int FaultId { get; set; }
        public string Fault_Name { get; set; }
        public string Selected_Fault { get; set; }
        public string Case { get; set; }
        public string Fault_Description { get; set; }

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
