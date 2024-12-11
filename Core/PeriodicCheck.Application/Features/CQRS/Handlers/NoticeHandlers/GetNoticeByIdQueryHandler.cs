using PeriodicCheck.Application.Features.CQRS.Queries.NoticeQueries;
using PeriodicCheck.Application.Features.CQRS.Results.NoticeResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handlers.NoticeHandlers
{
    public class GetNoticeByIdQueryHandler
    {
        private readonly IRepository<Notice> _repository;

        public GetNoticeByIdQueryHandler(IRepository<Notice> repository)
        {
            _repository = repository;
        }
        public async Task<GetNoticeByIdQueryResult> Handle(GetNoticeByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetNoticeByIdQueryResult
            {
                 Equipment_id=values.Equipment_id,
                 Notice_id=values.Notice_id,
                 Deleted_date=values.Deleted_date,
                 Deleted_user=values.Deleted_user,
                 Ins_date=values.Ins_date,
                 Ins_user=values.Ins_user,
                 Is_active=values.Is_active,
                 Is_deleted=values.Is_deleted,
                 Notice_date=values.Notice_date,
                 Notice_type=values.Notice_type,
                 Updated_date=values.Updated_date,
                 Updated_user=values.Updated_user,
                 İncharge_mail = values.İncharge_mail
            };
        }
    }
}
