using TwoOneHomes.Domain.ClientAppLayout;
using TwoOneHomes.Persistence.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TwoOneHomes.Persistence.Configuration;

public class NgFormLayoutConfiguration : IEntityTypeConfiguration<NgFormLayout>
{
    public void Configure(EntityTypeBuilder<NgFormLayout> builder)
    {
        builder.ToTable(TableNames.NgFormLayouts);
        builder.HasKey(x => x.Id);
    }
}