using push_notifications.Models;

namespace push_notifications.Helpers
{
    public static class HttpResponseHelper
    {
        public static HttpResponseDto Success(string message = "", string status = "", object data = null)
        {
            return new HttpResponseDto
            {
                Message = message,
                Status = status,
                Data = data,
                Errors = new List<object>()
            };
        }

        public static HttpResponseDto Error(string message = "", string status = "", object errors = null)
        {
            return new HttpResponseDto
            {
                Message = message,
                Status = status,
                Data = new List<object>(),
                Errors = errors
            };
        }
    }
}
