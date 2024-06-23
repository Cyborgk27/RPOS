using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPOS.Domain.Entities;

namespace RPOS.Infrastructure.Persistences.Contexts.Configurations
{
    internal class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("RestaurantId");

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasMany(x => x.Products)
                .WithOne(p => p.Restaurant)
                .HasForeignKey(p => p.RestaurantId);

            builder.HasOne(r => r.Address)
                .WithOne(a => a.Restaurant)
                .HasForeignKey<Address>(a => a.RestaurantId);
        }
    }
}
