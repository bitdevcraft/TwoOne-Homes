using TwoOneHomes.Domain.Entities.Finances.PaymentIntents;
using TwoOneHomes.Domain.Entities.Finances.Transactions.Enums;
using TwoOneHomes.Domain.Primitives;
using TwoOneHomes.Domain.Users;

namespace TwoOneHomes.Domain.Entities.Finances.Transactions;

public class Transaction : Entity, IAuditableEntity
{
    public Transaction()
    {
        
    }
    public Transaction(User user, PaymentIntent paymentIntent, string transactionId, decimal amount,
        string currency)
    {
        User = user;
        UserId = user.Id;
        PaymentIntent = paymentIntent;
        PaymentIntentId = paymentIntent.Id;
        TransactionId = transactionId;
        Amount = amount;
        Currency = currency;
    }

    public DateTime CreatedOnUtc { get; set; }
    public DateTime? ModifiedOnUtc { get; set; }

    public decimal Amount { get; set; }
    public string? Currency { get; set; }
    public DateTime TransactionDate { get; set; }
    public string? TransactionId { get; set; }
    public TransactionType TransactionType { get; set; }
    public string? PaymentMethod { get; set; }

    // Relationship
    public PaymentIntent? PaymentIntent { get; set; }
    public Ulid PaymentIntentId { get; set; }

    public User? User { get; set; }
    public Ulid UserId { get; set; }
}