using Microsoft.Extensions.DependencyInjection;

namespace TwoOneHomes.Presentation;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentationServices(this IServiceCollection services)
    {
        services
            .AddControllers()
            .AddApplicationPart(TwoOneHomes.Presentation.AssemblyReference.Assembly);
        return services;
    }
}
