using push_notifications.Constants;
using push_notifications.Models;
using push_notifications.Models.Notifications.Request;
using System.Text;
using System.Text.Json;


namespace push_notifications.Service.Notifications
{
    public class NotificationService
    {
        private readonly HttpClient _httpClient;

        public NotificationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ServiceResponseDto> SimpleNotification(SimpleNotificationRequest req)
        {

            var request = new HttpRequestMessage(HttpMethod.Post, "https://onesignal.com/api/v1/notifications");

            request.Headers.Add("Authorization", $"Basic {req.ONESIGNAL_REST_API_KEY}");

            var payload = new
            {
                app_id = req.ONESIGNAL_APP_ID,
                headings = new { en = req.Title },
                contents = new { en = req.Message },
                include_player_ids = new[] { req.PlayerId }  // Este es el ID del dispositivo
            };

            request.Content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");

            var response = await _httpClient.SendAsync(request);
  

            return new ServiceResponseDto
            {
                Message = "Send simple push notification.",
                Status = ServiceConstant.STATUS_SERVICES_OK,
                Success = true,
                Data = response
            };
        }


    }
}
