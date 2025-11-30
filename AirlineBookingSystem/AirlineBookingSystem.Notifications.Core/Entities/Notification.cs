namespace AirlineBookingSystem.Notifications.Core.Entities
{
    internal class Notification
    {
        public Guid Id { get; set; }
        public string Recipiente { get; set; }
        public string Messagesd { get; set; }
        public string Type { get; set; }
    }
}
