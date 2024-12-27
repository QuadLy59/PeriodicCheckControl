using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Queries.FaultNameQueries
{
    public class GetFaultNameByIdQuery
    {
        public int Id { get; set; }

        public GetFaultNameByIdQuery(int id)
        {
            Id = id;
        }
    }
}
