using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RPOS.Domain.Entities;

namespace RPOS.Infrastructure.Persistences.Contexts.Configurations
{
    public class MenuForDayConfiguration : IEntityTypeConfiguration<MenuForDay>
    {
        public void Configure(EntityTypeBuilder<MenuForDay> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id)
                .HasColumnName("MenuId");

            builder.HasMany(m => m.Products)
                .WithOne(p => p.MenuForDay)
                .HasForeignKey(p => p.MenuId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
