using PeriodicCheck.Application.Features.CQRS.Command.CategoryCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.CategoryHandler
{
    public class CreateCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;

        public CreateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCategoryCommand command)
        {
            await _repository.CreateAsync(new Category
            {
                CategoryName = command.CategoryName,
                Ins_user = command.Ins_user,
                Ins_date = command.Ins_date,
                Is_active = command.Is_active

            });
        }
    }
}
