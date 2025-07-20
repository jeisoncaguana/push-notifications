namespace push_notifications.Models
{
    public class HttpResponseDto
    {
        public required string Message { get; set; }
        public required string Status { get; set; }
        public required object Data { get; set; }
        public required object Errors { get; set; } 
    }
}
