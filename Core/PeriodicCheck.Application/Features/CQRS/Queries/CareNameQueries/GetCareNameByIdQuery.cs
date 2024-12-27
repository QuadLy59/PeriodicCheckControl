using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Queries.CareNameQueries
{
    public class GetCareNameByIdQuery
    {
        public int Id { get; set; }

        public GetCareNameByIdQuery(int id)
        {
            Id = id;
        }
    }
}
