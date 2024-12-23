﻿using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Identity;
using TwoOneHomes.Domain.Entities.Accounts;
using TwoOneHomes.Domain.Users.Activities;
using TwoOneHomes.Domain.Users.Roles;
using TwoOneHomes.Domain.Users.Tokens;

namespace TwoOneHomes.Domain.Users;

public class User : IdentityUser<Ulid>
{
    public User()
    {
        Id = Ulid.NewUlid();
        SecurityStamp = Guid.NewGuid().ToString();
    }

    public virtual ICollection<UserRole> UserRoles { get; set; } = [];
    public virtual ICollection<RefreshToken> RefreshTokens { get; set; } = [];
    public virtual ICollection<UserActivity> UserActivities { get; set; } = [];

    public User? Manager { get; set; }
    public Ulid? ManagerId { get; set; }
    public ICollection<User>? Members { get; set; }

    public string FullName => 
        Regex.Replace($"{Salutation} {FirstName} {LastName} {Suffix}".Trim(), 
            @"\s+", " ");

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? MiddleName { get; set; }
    public string? Suffix { get; set; }
    public string? Salutation { get; set; }
    public string? Mobile { get; set; }
    public string? Phone { get; set; }
    public string? Fax { get; set; }
    public string? Title { get; set; }
    public bool Active { get; set; } = true;

    // Relationship
    public Account? Account { get; set; }
}