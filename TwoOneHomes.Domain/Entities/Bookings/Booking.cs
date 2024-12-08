using TwoOneHomes.Domain.Entities.Accounts;
using TwoOneHomes.Domain.Entities.Inventories;
using TwoOneHomes.Domain.Entities.Inventories.Properties;
using TwoOneHomes.Domain.Entities.Inventories.Properties.Enums;
using TwoOneHomes.Domain.Primitives;
using TwoOneHomes.Domain.Users;

namespace TwoOneHomes.Domain.Entities.Bookings;

public class Booking : Entity, IAuditableEntity, IAccountOwned
{
    public Booking(Property property)
    {
        Property = property;
        PropertyId = property.Id;
        Category = property.Category;
    }

    public DateTime CreatedOnUtc { get; set; }
    public DateTime? ModifiedOnUtc { get; set; }

    public string? Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public decimal SalesPrice { get; set; }
    public decimal TotalPrice { get; set; }
    public PropertyCategory Category { get; set; }
    public BookingStatus Status { get; set; }

    public string StatusType =>
        Status switch
        {
            BookingStatus.Active => "Active",
            BookingStatus.Cancelled => "Cancelled",
            BookingStatus.Completed => "Completed",
            BookingStatus.Confirmed => "Confirmed",
            BookingStatus.Expired => "Expired",
            BookingStatus.Pending => "Pending",
            BookingStatus.Rejected => "Rejected",
            BookingStatus.PaymentCompleted => "Payment completed",
            BookingStatus.PaymentPending => "Payment pending",
            _ => string.Empty,
        };


    public Ulid? MainCustomerId { get; set; }
    public ICollection<BookingCustomer> Customers { get; set; } = [];
    public ICollection<Account> Brokers { get; set; } = [];
    
    // Relationship
    public Ulid PropertyId { get; set; }
    public Property Property { get; set; }

    public Account? Owner { get; set; }
    public Ulid? OwnerId { get; set; }
}