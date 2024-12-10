using TwoOneHomes.Domain.Entities.Finances.Refunds.Enums;
using TwoOneHomes.Domain.Entities.Finances.Transactions;
using TwoOneHomes.Domain.Primitives;

namespace TwoOneHomes.Domain.Entities.Finances.Refunds;

public class Refund : Entity, IAuditableEntity
{
    public Refund()
    {
        
    }
    public Refund(Transaction transaction)
    {
        Transaction = transaction;
        TransactionId = transaction.Id;
    }
    public DateTime CreatedOnUtc { get; set; }
    public DateTime? ModifiedOnUtc { get; set; }
    public RefundStatus Status { get; set; }
    public decimal RefundAmount { get; set; }
    public DateTime RefundDate { get; set; }
    public string? StripeRefundId { get; set; }
    // Relationship

    public Transaction? Transaction { get; set; }
    public Ulid TransactionId { get; set; }
}