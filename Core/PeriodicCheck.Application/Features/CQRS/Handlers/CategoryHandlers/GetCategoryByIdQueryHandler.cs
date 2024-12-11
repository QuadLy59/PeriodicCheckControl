using PeriodicCheck.Application.Features.CQRS.Queries.CategoryQueries;
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
    public class GetCategoryByIdQueryHandler
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryByIdQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCategoryByIdQueryResult
            {
                Category_id = values.Category_id,
                Category_name = values.Category_name,
                Deleted_date = values.Deleted_date,
                Deleted_user = values.Deleted_user,
                Ins_date = values.Ins_date,
                Ins_user = values.Ins_user,
                Is_active = values.Is_active,
                Is_deleted = values.Is_deleted,
                Updated_date = values.Updated_date,
                Updated_user = values.Updated_user,
            };
        }
    }
}
