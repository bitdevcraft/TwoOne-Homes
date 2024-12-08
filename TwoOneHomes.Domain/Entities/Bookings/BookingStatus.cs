namespace TwoOneHomes.Domain.Entities.Bookings;

public enum BookingStatus
{
    Pending,
    Confirmed,
    PaymentPending,
    PaymentCompleted,
    Active,
    Completed,
    Expired,
    Cancelled,
    Rejected,
}