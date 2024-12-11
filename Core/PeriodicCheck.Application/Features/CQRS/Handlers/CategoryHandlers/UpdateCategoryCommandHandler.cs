using PeriodicCheck.Application.Features.CQRS.Commands.CategoryCommands;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;

        public UpdateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCategoryCommand command)
        {
            var values =await _repository.GetByIdAsync(command.Category_id);
            values.Category_name = command.Category_name;
            values.Updated_date = command.Updated_date;
            values.Updated_user = command.Updated_user;
            values.Is_active = command.Is_active;      
            await _repository.UpdateAsync(values);
        }
    }
}
