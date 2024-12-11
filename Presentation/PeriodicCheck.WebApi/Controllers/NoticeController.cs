using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeriodicCheck.Application.Features.CQRS.Commands.NoticeCommands;
using PeriodicCheck.Application.Features.CQRS.Handlers.NoticeHandlers;
using PeriodicCheck.Application.Features.CQRS.Queries.NoticeQueries;

namespace PeriodicCheck.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticeController : ControllerBase
    {
        private readonly CreateNoticeCommandHandler _createCommandHandler;
        private readonly GetNoticeByIdQueryHandler _getNoticeByIdQueryHandler;
        private readonly GetNoticeQueryHandler _getNoticeQueryHandler;
        private readonly UpdateNoticeCommandHandler _updateCommandHandler;
        private readonly RemoveNoticeCommandHandler _removeCommandHandler;

        public NoticeController(CreateNoticeCommandHandler createCommandHandler, GetNoticeByIdQueryHandler getNoticeByIdQueryHandler, GetNoticeQueryHandler getNoticeQueryHandler, UpdateNoticeCommandHandler updateCommandHandler, RemoveNoticeCommandHandler removeCommandHandler)
        {
            _createCommandHandler = createCommandHandler;
            _getNoticeByIdQueryHandler = getNoticeByIdQueryHandler;
            _getNoticeQueryHandler = getNoticeQueryHandler;
            _updateCommandHandler = updateCommandHandler;
            _removeCommandHandler = removeCommandHandler;
        }
        [HttpGet]
        public async Task<IActionResult> NoticeList()
        {
            var values = await _getNoticeQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetNotice(int id)
        {
            var value = await _getNoticeByIdQueryHandler.Handle(new GetNoticeByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateNotice(CreateNoticeCommand command)
        {
            await _createCommandHandler.Handle(command);
            return Ok("Bildirim Bilgisi Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveNotice(int id)
        {
            await _removeCommandHandler.Handle(new RemoveNoticeCommand(id));
            return Ok("Bildirim Bilgisi Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateNotice(UpdateNoticeCommand command)
        {
            await _updateCommandHandler.Handle(command);
            return Ok("Bildirim Bilgisi Güncellendi");
        }
    }
}
