using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Queries.AuthorityQueries
{
    public class GetWarehouseByIdQuery
    {
        public int Id { get; set; }

        public GetWarehouseByIdQuery(int id)
        {
            Id = id;
        }
    }
}
