namespace AirlineBookingSystem.Flights.Core.Entities
{
    public class Flight
    {
        public Guid Id { get; set; }
        public string FlightName { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}
