using TwoOneHomes.Domain.Entities.Inventories.PaymentPlans;

namespace TwoOneHomes.Domain.Repositories.Features.Inventories;

public interface IProjectRepository
{
    Task AddPaymentPlan(PaymentPlan paymentPlan);
}