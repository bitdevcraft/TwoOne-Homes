using TwoOneHomes.Domain.Primitives;
using TwoOneHomes.Domain.Entities.Accounts;

namespace TwoOneHomes.Domain.Entities.Bookings;

public class BookingBroker : Entity
{
    public BookingBroker()
    {
        
    }
    public BookingBroker(Account account, Booking booking)
    {
        Account = account;
        AccountId = account.Id;
        Booking = booking;
        BookingId = booking.Id;
    }

    public Account? Account { get; set; }
    public Ulid AccountId { get; set; }
    public Booking? Booking { get; set; }
    public Ulid BookingId { get; set; }
    public bool MainOwner { get; set; }
}