namespace AirlineBookingSystem.Bookings.Core.Entities.Repositories
{
    internal interface IBookingRepository
    {
        Task<Booking> GetBookingByIdAsync(Guid id);
        Task AddBookingAsync(Booking booking);
    }
}
