using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace push_notifications.Models.Notifications.Request
{
    public class SimpleNotificationRequest
    {
        [Required(ErrorMessage = "Title is required")]
        [DefaultValue("Hello!")]
        public required string Title { get; set; }

        [Required(ErrorMessage = "Message is required")]
        [DefaultValue("Hello!!!!")]
        public required string Message { get; set; }


        [Required(ErrorMessage = "PlayerId is required")]
        [DefaultValue("805cf420b5cefe797d78e3332ab168bc3b28a7177033eb72349af01dfe63cbb61d80d5aab4881fb4b9a4fe904d312190054f6c19c921e330a423c776eb888a58d01d37fb51b39d3fd6af15170e2fea09")]
        public required string PlayerId { get; set; }

        [Required(ErrorMessage = "ONESIGNAL_APP_ID is required")]
        [DefaultValue("ONESIGNAL_APP_ID")]
        public required string ONESIGNAL_APP_ID { get; set; }

        [Required(ErrorMessage = "ONESIGNAL_REST_API_KEY is required")]
        [DefaultValue("ONESIGNAL_REST_API_KEY")]
        public required string ONESIGNAL_REST_API_KEY { get; set; } 
    }
}
