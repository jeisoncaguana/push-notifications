using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace push_notifications.Models.Notifications.Request
{
    public class SimpleNotificationRequest
    {
        [Required(ErrorMessage = "Message is required")]
        [DefaultValue("Hello!!")]
        public required string Message { get; set; }
    }
}
