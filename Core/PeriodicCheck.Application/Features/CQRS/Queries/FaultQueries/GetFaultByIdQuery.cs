using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Queries.RoleQueries
{
    public class GetFaultByIdQuery
    {
        public int Id { get; set; }

        public GetFaultByIdQuery(int id)
        {
            Id = id;
        }
    }
}
