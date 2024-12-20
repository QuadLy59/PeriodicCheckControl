using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Queries.AuthorityQueries
{
    public class GetAuthorityByIdQuery
    {
        public int Id { get; set; }

        public GetAuthorityByIdQuery(int id)
        {
            Id = id;
        }
    }
}
