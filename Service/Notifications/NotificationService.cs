using push_notifications.Constants;
using push_notifications.Models;
using push_notifications.Models.Notifications.Request;


namespace push_notifications.Service.Notifications
{
    
    public class NotificationService
    {
        public NotificationService()
        {
        }

        public async Task<ServiceResponseDto> SimpleNotification(SimpleNotificationRequest request)
        {
            
            /*
            if (!userResult.Success)
                return new ServiceResponseDto
                {
                    Message = userResult.Message,
                    Status = ServiceConstant.STATUS_SERVICES_OK,
                    Success = false,
                    Error = userResult.Error,
                    Data = new List<object>()
                };
            */


            return new ServiceResponseDto
            {
                Message = "Send simple push notification.",
                Status = ServiceConstant.STATUS_SERVICES_OK,
                Success = true,
                Data = request
            };
        }


    }
}
