namespace push_notifications.Models
{
    public class ServiceResponseDto
    {
        public required string Message { get; set; }
        public required string Status { get; set; }
        public required bool Success { get; set; }
        public object? Data { get; set; }
        public object? Error { get; set; }
    }
}
