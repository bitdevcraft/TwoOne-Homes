using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoOneHomes.Domain.Users.Activities;
using TwoOneHomes.Persistence.Constants;

namespace TwoOneHomes.Persistence.Configuration.UserConfigurations;

public class UserActivityConfiguration : IEntityTypeConfiguration<UserActivity>
{
    public void Configure(EntityTypeBuilder<UserActivity> builder)
    {
        builder.HasKey(x => x.Id);

        builder.ToTable(TableNames.SysUserActivities);
    }
}