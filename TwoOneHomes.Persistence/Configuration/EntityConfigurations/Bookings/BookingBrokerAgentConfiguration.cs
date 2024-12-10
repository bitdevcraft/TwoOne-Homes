using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoOneHomes.Domain.Entities.Bookings;

namespace TwoOneHomes.Persistence.Configuration.EntityConfigurations.Bookings;

public class BookingBrokerAgentConfiguration : IEntityTypeConfiguration<BookingBrokerAgent>
{
    public void Configure(EntityTypeBuilder<BookingBrokerAgent> builder)
    {
        builder.ToTable("BookingBrokerAgents");
        builder.HasKey(x => x.Id);
    }
}