using TwoOneHomes.App;
using TwoOneHomes.App.Middlewares;
using TwoOneHomes.Application;
using TwoOneHomes.Infrastructure;
using TwoOneHomes.Persistence;
using TwoOneHomes.Persistence.Seed;
using TwoOneHomes.Presentation;
using TwoOneHomes.ServiceDefaults;
using Scrutor;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();


// Add services to the container.
// Dependency Injection of Layers
{
    builder
        .Services.AddAppServices()
        .AddPersistenceService(builder.Configuration)
        .AddApplicationServices()
        .AddInfrastructureServices(builder.Configuration)
        .AddPresentationServices();
}

builder.Services.Scan(selector =>
    selector
        .FromAssemblies(
            TwoOneHomes.Infrastructure.AssemblyReference.Assembly,
            TwoOneHomes.Persistence.AssemblyReference.Assembly
        )
        .AddClasses(false)
        .UsingRegistrationStrategy(RegistrationStrategy.Skip)
        .AsImplementedInterfaces()
        .WithScopedLifetime()
);

WebApplication app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    await app.InitialiseDatabaseAsync();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.UseMiddleware<ExceptionMiddleware>();

app.MapControllers();

app.MapFallbackToFile("/index.html");

#pragma warning disable CA1849 // Call async methods when in an async method
app.Run();
#pragma warning restore CA1849 // Call async methods when in an async method
