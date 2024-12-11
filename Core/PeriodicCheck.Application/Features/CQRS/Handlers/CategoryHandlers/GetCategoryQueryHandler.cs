using PeriodicCheck.Application.Features.CQRS.Results.CategoryResults;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var values =await _repository.GetAllAsync();
            return values.Select(x=> new GetCategoryQueryResult
            {
                Category_id = x.Category_id,
                Category_name = x.Category_name,    
                Deleted_date = x.Deleted_date,
                Deleted_user = x.Deleted_user,
                Ins_date = x.Ins_date,
                Ins_user = x.Ins_user,
                Is_active = x.Is_active,
                Is_deleted = x.Is_deleted,
                Updated_date = x.Updated_date,
                Updated_user = x.Updated_user,
                
            }).ToList();
        }
    }
}
