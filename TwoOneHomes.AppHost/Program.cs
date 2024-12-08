IDistributedApplicationBuilder builder = DistributedApplication.CreateBuilder(args);

IResourceBuilder<RedisResource> cache = builder.AddRedis("cache");

builder.AddProject<Projects.TwoOneHomes_App>("twoonehomes-app")
    .WithReference(cache);

builder.Build().Run();