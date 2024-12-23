using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Queries.EquipmentQueries
{
    public class GetEquipmentByIdQuery
    {
        public int Id { get; set; }

        public GetEquipmentByIdQuery(int id)
        {
            Id = id;
        }
    }
}
