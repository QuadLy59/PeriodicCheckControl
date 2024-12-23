using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Queries.CareDetailQueries
{
    public class GetCareDetailByIdQuery
    {
        public int Id { get; set; }

        public GetCareDetailByIdQuery(int id)
        {
            Id = id;
        }
    }
}
