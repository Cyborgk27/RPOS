using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPOS.Domain.Entities;

namespace RPOS.Infrastructure.Persistences.Contexts.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
                .HasColumnName("AddressId");

            builder.Property(a => a.FirstStreet)
                .HasMaxLength(100);  // Asumimos una longitud máxima de 100 para el ejemplo

            builder.Property(a => a.SecondStreet)
                .HasMaxLength(100);  // Asumimos una longitud máxima de 100 para el ejemplo

            builder.HasOne(a => a.Restaurant)
                .WithOne(r => r.Address)
                .HasForeignKey<Address>(a => a.RestaurantId);
        }
    }
}
