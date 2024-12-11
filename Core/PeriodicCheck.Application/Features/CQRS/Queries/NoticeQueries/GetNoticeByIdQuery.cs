using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Queries.NoticeQueries
{
    public class GetNoticeByIdQuery
    {
        public int Id { get; set; }

        public GetNoticeByIdQuery(int id)
        {
            Id = id;
        }
    }
}
