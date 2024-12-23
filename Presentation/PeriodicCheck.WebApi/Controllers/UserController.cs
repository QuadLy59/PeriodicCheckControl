using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeriodicCheck.Application.Features.CQRS.Command.UserCommand;
using PeriodicCheck.Application.Features.CQRS.Handler.UserHandler;
using PeriodicCheck.Application.Features.CQRS.Queries.UserQueries;

namespace PeriodicCheck.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly CreateUserCommandHandler _createUserCommandHandler;
        private readonly GetUserByIdQueryHandler _getUserByIdQueryHandler;
        private readonly GetUserQueryHandler _getUserQueryHandler;
        private readonly UpdateUserCommandHandler _updateUserCommandHandler;
        private readonly RemoveUserCommandHandler _removeUserCommandHandler;
        public UserController(CreateUserCommandHandler createUserCommandHandler, GetUserByIdQueryHandler getUserByIdQueryHandler, GetUserQueryHandler getUserQueryHandler, UpdateUserCommandHandler updateUserCommandHandler, RemoveUserCommandHandler removeUserCommandHandler)
        {
            _createUserCommandHandler = createUserCommandHandler;
            _getUserByIdQueryHandler = getUserByIdQueryHandler;
            _getUserQueryHandler = getUserQueryHandler;
            _updateUserCommandHandler = updateUserCommandHandler;
            _removeUserCommandHandler = removeUserCommandHandler;
        }


        [HttpGet]
        public async Task<IActionResult> UserList()
        {
            var values = await _getUserQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var value = await _getUserByIdQueryHandler.Handle(new GetUserByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommand command)
        {
            await _createUserCommandHandler.Handle(command);
            return Ok("Bilgi Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveUser(int id)
        {
            await _removeUserCommandHandler.Handle(new RemoveUserCommand(id));
            return Ok("Bilgi Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateUser(UpdateUserCommand command)
        {
            await _updateUserCommandHandler.Handle(command);
            return Ok("Bilgi Eklendi");
        }
    }
}
