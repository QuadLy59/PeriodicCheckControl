using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Queries.RoleQueries
{
    public class GetFaultDetailByIdQuery
    {
        public int Id { get; set; }

        public GetFaultDetailByIdQuery(int id)
        {
            Id = id;
        }
    }
}
