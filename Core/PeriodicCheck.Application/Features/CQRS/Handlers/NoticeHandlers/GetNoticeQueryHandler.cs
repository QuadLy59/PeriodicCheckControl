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
    public class GetNoticeQueryHandler
    {
        private readonly IRepository<Notice> _repository;

        public GetNoticeQueryHandler(IRepository<Notice> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetNoticeQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=>new GetNoticeQueryResult
            {
                Equipment_id = x.Equipment_id,
                Notice_id = x.Notice_id,
                Deleted_date = x.Deleted_date,
                Deleted_user = x.Deleted_user,
                Ins_date = x.Ins_date,
                Ins_user = x.Ins_user,
                Is_active = x.Is_active,
                Is_deleted = x.Is_deleted,
                Notice_date = x.Notice_date,
                Notice_type = x.Notice_type,
                Updated_date = x.Updated_date,
                Updated_user = x.Updated_user,
                İncharge_mail=x.İncharge_mail,
            }).ToList();
        }
    }
}
