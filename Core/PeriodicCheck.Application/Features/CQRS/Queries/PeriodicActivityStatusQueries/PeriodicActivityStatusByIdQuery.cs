using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Queries.PeriodicActivityStatusQueries
{
    public class PeriodicActivityStatusByIdQuery
    {
        public int Id { get; set; }

        public PeriodicActivityStatusByIdQuery(int id)
        {
            Id = id;
        }
    }
}
