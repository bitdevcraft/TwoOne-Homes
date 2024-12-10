using TwoOneHomes.Domain.Entities.Inventories.PaymentPlans;

namespace TwoOneHomes.Domain.Entities.Inventories.Projects;

public class ProjectInstallmentPlan 
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

    public Ulid Id { get; private init; } = Ulid.NewUlid();
    public Project? Project { get; set; }
    public Ulid ProjectId { get; set; }
    public PaymentPlan? PaymentPlan { get; set; }
    public Ulid PaymentPlanId { get; set; }
    
}