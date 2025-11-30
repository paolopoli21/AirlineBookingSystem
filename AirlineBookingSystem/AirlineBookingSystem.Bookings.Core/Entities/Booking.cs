namespace AirlineBookingSystem.Bookings.Core.Entities
{
    internal class Booking
    {
        public Guid Guid { get; set; }
        public Guid FlightId { get; set; }
        public string PassengerName { get; set; }
        public string SeatNumber { get; set; }
        public string BookingDate { get; set; }
    }
}
