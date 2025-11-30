namespace AirlineBookingSystem.Flights.Core.Entities.Repositories
{
    public interface IFlightRepository
    {
        public Task<IEnumerable<Flight>> GetFlightAsync();
        Task AddFlightAsync(Flight flight);
        Task DeleteFlightAsync(Flight flight);
    }
}
