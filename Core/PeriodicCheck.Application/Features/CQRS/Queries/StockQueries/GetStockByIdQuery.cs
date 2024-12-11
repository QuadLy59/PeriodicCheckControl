using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Queries.StockQueries
{
    public class GetStockByIdQuery
    {
        public int Id { get; set; }

        public GetStockByIdQuery(int id)
        {
            Id = id;
        }
    }
}
