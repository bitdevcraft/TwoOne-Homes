using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoOneHomes.Domain.Entities.Accounts;

namespace TwoOneHomes.Persistence.Configuration.EntityConfigurations.Accounts;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.ToTable("Accounts");
        
        builder.HasKey(x => x.Id);
        
        // Self-Referencing
        builder.HasOne(x => x.ParentAccount)
            .WithMany(x => x.SubAccounts)
            .HasForeignKey(x => x.ParentAccountId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(x => x.Employees)
            .WithOne(x => x.Account);
        
        
    }
}