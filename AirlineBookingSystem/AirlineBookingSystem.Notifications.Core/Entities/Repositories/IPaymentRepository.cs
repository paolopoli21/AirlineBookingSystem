namespace AirlineBookingSystem.Notifications.Core.Entities.Repositories
{
    internal class IPaymentRepository
    {
        Task ProcessPaymentAsync(Payment payment);
    }
}
