using Microsoft.AspNetCore.Mvc;
using Interfaces;

namespace Controller
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public HomeController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpPost("send-notification")]
        public IActionResult SendNotification([FromQuery] string type, [FromQuery] string recipient, [FromQuery] string message)
        {
            bool result = false;
            if (type.ToLower() == "email")
            {
                result = _notificationService.SendEmail(recipient, message);
            }
            else if (type.ToLower() == "sms")
            {
                result = _notificationService.SendSMS(recipient, message);
            }
            else
            {
                return BadRequest("Invalid notification type. Use 'email' or 'sms'.");
            }

            if (result)
            {
                return Ok("Notification sent successfully.");
            }
            else
            {
                return StatusCode(500, "Failed to send notification.");
            }
        }
    }
}
