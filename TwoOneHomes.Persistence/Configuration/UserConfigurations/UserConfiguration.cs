using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoOneHomes.Domain.Users;
using TwoOneHomes.Persistence.Constants;

namespace TwoOneHomes.Persistence.Configuration.UserConfigurations;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable(TableNames.SysUsers);

        // Each User can have many entries in the UserRole join table
        builder.HasMany(e => e.UserRoles)
            .WithOne(e => e.User)
            .HasForeignKey(ur => ur.UserId)
            .IsRequired();

        builder.HasMany(e => e.UserActivities)
            .WithOne(e => e.User)
            .HasForeignKey(ur => ur.UserId)
            .IsRequired();

        builder.HasMany(e => e.RefreshTokens)
            .WithOne(e => e.User)
            .HasForeignKey(ur => ur.UserId)
            .IsRequired();

        builder.HasOne(e => e.Account)
            .WithMany(e => e.Employees)
            .HasForeignKey(e => e.AccountId);

        // Self-Referencing
        builder.HasOne(x => x.Manager)
            .WithMany(x => x.Members)
            .HasForeignKey(x => x.ManagerId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Restrict);
    }
}