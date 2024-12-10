using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoOneHomes.Domain.ClientAppLayout;
using TwoOneHomes.Persistence.Constants;

namespace TwoOneHomes.Persistence.Configuration.ClientWebConfigurations;

public class NgFormLayoutConfiguration : IEntityTypeConfiguration<NgFormLayout>
{
    public void Configure(EntityTypeBuilder<NgFormLayout> builder)
    {
        builder.ToTable("FormLayouts", "web");
        builder.HasKey(x => x.Id);
    }
}