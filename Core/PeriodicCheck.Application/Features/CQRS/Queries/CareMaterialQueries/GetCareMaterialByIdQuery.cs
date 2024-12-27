using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Queries.CareMaterialQueries
{
    public class GetCareMaterialByIdQuery
    {
        public int Id { get; set; }

        public GetCareMaterialByIdQuery(int id)
        {
            Id = id;
        }
    }
}
