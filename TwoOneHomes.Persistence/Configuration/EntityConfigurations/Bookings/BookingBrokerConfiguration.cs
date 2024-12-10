using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoOneHomes.Domain.Entities.Bookings;

namespace TwoOneHomes.Persistence.Configuration.EntityConfigurations.Bookings;

public class BookingBrokerConfiguration : IEntityTypeConfiguration<BookingBroker>
{
    public void Configure(EntityTypeBuilder<BookingBroker> builder)
    {
        builder.ToTable("BookingBrokers");
        builder.HasKey(x => x.Id);
    }
}