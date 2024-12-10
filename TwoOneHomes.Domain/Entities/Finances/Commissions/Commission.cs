using TwoOneHomes.Domain.Entities.Accounts;
using TwoOneHomes.Domain.Entities.Bookings;
using TwoOneHomes.Domain.Entities.Finances.Commissions.Enums;
using TwoOneHomes.Domain.Primitives;

namespace TwoOneHomes.Domain.Entities.Finances.Commissions;

public class Commission : Entity, IAuditableEntity
{
    private decimal _amount;

    public Commission()
    {
        
    }
    public Commission(Booking booking, Account broker)
    {
        Booking = booking;
        BookingId = booking.Id;
        Broker = broker;
        BrokerId = broker.Id;
    }
    public DateTime CreatedOnUtc { get; set; }
    public DateTime? ModifiedOnUtc { get; set; }

    public decimal Percentage { get; set; }
    public decimal Amount
    {
        get
        {
            if (Percentage > 0 && Booking != null)
            {
                _amount = Booking.SalesPrice * Percentage / 100;
                return _amount;
            }

            return _amount;
        }
        set => _amount = value;
    }

    public CommissionStatus Status { get; set; }
    
    // Relationship
    public Booking? Booking { get; set; }
    public Ulid BookingId { get; set; }

    public Account? Broker { get; set; }
    public Ulid BrokerId { get; set; }
    
}