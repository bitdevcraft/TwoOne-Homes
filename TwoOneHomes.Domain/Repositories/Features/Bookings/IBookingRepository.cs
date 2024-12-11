namespace TwoOneHomes.Domain.Repositories.Features.Bookings;

public interface IBookingRepository
{
    // Selling
    // Leasing
    Task CancelOtherBookingAsync(Ulid bookingId, Ulid propertyId);


    // Rental
}