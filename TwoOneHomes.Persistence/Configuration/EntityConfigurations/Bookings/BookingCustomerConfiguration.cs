using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoOneHomes.Domain.Entities.Bookings;

namespace TwoOneHomes.Persistence.Configuration.EntityConfigurations.Bookings;

public class BookingCustomerConfiguration : IEntityTypeConfiguration<BookingCustomer>
{
    public void Configure(EntityTypeBuilder<BookingCustomer> builder)
    {
        builder.ToTable("BookingCustomers");
        builder.HasKey(x => x.Id);
    }
}