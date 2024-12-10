using TwoOneHomes.Domain.Entities.Bookings;
using TwoOneHomes.Domain.Entities.Finances.PaymentIntents.Enums;
using TwoOneHomes.Domain.Primitives;
using TwoOneHomes.Domain.Users;

namespace TwoOneHomes.Domain.Entities.Finances.PaymentIntents;

public class PaymentIntent : Entity, IAuditableEntity
{
    public PaymentIntent()
    {
        
    }
    public PaymentIntent(User user, Booking booking, string currency, decimal amount)
    {
        User = user;
        Booking = booking;
        Currency = currency;
        Amount = amount;
    }

    public DateTime CreatedOnUtc { get; set; }
    public DateTime? ModifiedOnUtc { get; set; }

    public decimal Amount { get; set; }
    public string? Currency { get; set; }
    public PaymentIntentStatus IntentStatus { get; set; }
    public string? StripePaymentIntentId { get; set; }
    public string? PaymentMethod { get; set; }
    public string? ClientSecret { get; set; }

    // Relationship
    public User? User { get; set; }
    public Ulid? UserId { get; set; }

    public Booking? Booking { get; set; }
    public Ulid? BookingId { get; set; }
}