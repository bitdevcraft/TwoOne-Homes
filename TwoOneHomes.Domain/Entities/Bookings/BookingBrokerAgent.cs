using TwoOneHomes.Domain.Primitives;
using TwoOneHomes.Domain.Users;

namespace TwoOneHomes.Domain.Entities.Bookings;

public class BookingBrokerAgent : Entity
{
    public BookingBrokerAgent()
    {
        
    }
    public BookingBrokerAgent(BookingBroker bookingBroker, User user)
    {
        BookingBroker = bookingBroker;
        BookingBrokerId = bookingBroker.Id;
        User = user;
        UserId = user.Id;
    }
    public BookingBroker? BookingBroker { get; set; }
    public Ulid BookingBrokerId { get; set; }
    public User? User { get; set; }
    public Ulid UserId { get; set; }
}