using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Queries.RoleQueries
{
    public class GetMaterialByIdQuery
    {
        public int Id { get; set; }

        public GetMaterialByIdQuery(int id)
        {
            Id = id;
        }
    }
}
