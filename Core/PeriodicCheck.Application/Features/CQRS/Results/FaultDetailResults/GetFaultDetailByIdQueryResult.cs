using PeriodicCheck.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace PeriodicCheck.Application.Features.CQRS.Results.FaultDetailResults
{
    public class GetFaultDetailByIdQueryResult
    {
        [Key]
        public int FaultDetailId { get; set; }
        public int? EquipmentId { get; set; }
        public int? FaultId { get; set; }
        public int? FaultNameId { get; set; }
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
