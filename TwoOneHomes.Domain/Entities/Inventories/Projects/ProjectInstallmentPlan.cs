using TwoOneHomes.Domain.Entities.Inventories.PaymentPlans;
using TwoOneHomes.Domain.Primitives;

namespace TwoOneHomes.Domain.Entities.Inventories.Projects;

public class ProjectInstallmentPlan : Entity
{
    public ProjectInstallmentPlan()
    {
        
    }
    public ProjectInstallmentPlan(Project project, PaymentPlan plan)
    {
        Project = project;
        ProjectId = project.Id;
        PaymentPlan = plan;
        PaymentPlanId = plan.Id;
    }
    public Project? Project { get; set; }
    public Ulid? ProjectId { get; set; }
    public PaymentPlan? PaymentPlan { get; set; }
    public Ulid? PaymentPlanId { get; set; }
    
}