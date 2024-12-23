using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Queries.CareReportQueries
{
    public class GetCareReportByIdQuery
    {
        public int Id { get; set; }

        public GetCareReportByIdQuery(int id)
        {
            Id = id;
        }
    }
}
