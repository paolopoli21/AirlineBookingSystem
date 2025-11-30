namespace AirlineBookingSystem.Payments.Core.Entities.Repositories
{
    public interface IPaymentRepository
    {
        Task ProcessPaymentAsync(Payment payment);
        Task RefundPaymentAsync(Guid id);
    }
}
