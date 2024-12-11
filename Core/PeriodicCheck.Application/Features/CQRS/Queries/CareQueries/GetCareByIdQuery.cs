using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Queries.CareQueries
{
    public class GetCareByIdQuery
    {
        public int Id { get; set; }

        public GetCareByIdQuery(int id)
        {
            Id = id;
        }
    }
}
