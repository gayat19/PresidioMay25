using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using FirstAPI.Misc;

namespace FirstAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IHubContext<NotificationHub> _hubContext;

        public MessageController(IHubContext<NotificationHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendMessage([FromQuery] string user, [FromQuery] string message)
        {
            await _hubContext.Clients.All.SendAsync("ReceiveMessage", user, message);
            return Ok(new { Status = "Message Sent", User = user, Message = message });
        }
    }
}
