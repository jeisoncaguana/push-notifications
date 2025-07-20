using Microsoft.AspNetCore.Mvc;
using push_notifications.Constants;
using push_notifications.Helpers;
using push_notifications.Models;
using push_notifications.Models.Notifications.Request;
using push_notifications.Service.Notifications;
 
namespace push_notifications.Controllers.Notifications
{
    [ApiController]
    [Route("[controller]")]
    public class NotificationController : ControllerBase
    {
        private readonly NotificationService notificationService;
        public NotificationController(NotificationService notificationService)
        {
            this.notificationService = notificationService;
        }
        [HttpPost("SimpleNotification")]
        [EndpointDescription("Sending simple push notification.")]
        public async Task<IActionResult> SimpleNotification([FromBody] SimpleNotificationRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(HttpResponseHelper.Error("Error sending simple push notification.", HttpConstant.STATUS_HTTP_ERROR, ModelState));

            ServiceResponseDto response = await this.notificationService.SimpleNotification(request);

            if (!response.Success)
                return BadRequest(HttpResponseHelper.Error(response.Message, HttpConstant.STATUS_HTTP_ERROR, response.Error ?? new object()));

            return Ok(HttpResponseHelper.Success(response.Message, HttpConstant.STATUS_HTTP_SUCCESS, response.Data ?? new object()));

        }
    }
}
