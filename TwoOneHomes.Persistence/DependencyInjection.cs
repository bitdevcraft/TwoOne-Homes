﻿using TwoOneHomes.Domain.Users;
using TwoOneHomes.Persistence.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TwoOneHomes.Domain.Users.Roles;

namespace TwoOneHomes.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceService(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        // Setup the connection to the Database
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
        );

        services.AddIdentityService(configuration);
        services.AddScoped<ApplicationDbContextInitialiser>();

        return services;
    }

    private static IServiceCollection AddIdentityService(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services
            .AddIdentityCore<User>()
            .AddRoles<Role>()
            .AddEntityFrameworkStores<ApplicationDbContext>();

        return services;
    }
}