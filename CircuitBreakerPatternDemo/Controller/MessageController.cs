using CircuitBreakerPatternDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace CircuitBreakerPatternDemo.Controller
{
    [Route("message")]
    public class MessageController : ControllerBase
    {
        private IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet("hello")]
        public async Task<IActionResult> GetHello()
        {
            var result = await _messageService.GetHelloMessage();
            return Ok(result);
        }

        [HttpGet("goodbye")]
        public async Task<IActionResult> GetGoodbye()
        {
            var result = await _messageService.GetGoodbyeMessage();
            return Ok(result);
        }
    }
}
