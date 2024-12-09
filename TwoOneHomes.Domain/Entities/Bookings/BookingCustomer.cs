using TwoOneHomes.Domain.Primitives;
using TwoOneHomes.Domain.Users;

namespace TwoOneHomes.Domain.Entities.Bookings;

public class BookingCustomer : Entity, IAuditableEntity
{
    public DateTime CreatedOnUtc { get; set; }
    public DateTime? ModifiedOnUtc { get; set; }
    
    public BookingCustomer(User user, Booking booking)
    {
        User = user;
        UserId = user.Id;
        Booking = booking;
        BookingId = booking.Id;
    }

    public User User { get; set; }
    public Ulid UserId { get; set; }
    public Booking Booking { get; set; }
    public Ulid BookingId { get; set; }
    public bool MainOwner { get; set; }

}