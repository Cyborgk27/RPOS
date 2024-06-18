using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RPOS.Domain.Entities;
using System.Reflection;

namespace RPOS.Infrastructure.Persistences.Contexts
{
    public partial class RPOSContext : IdentityDbContext
    {
        public RPOSContext()
        { 
        
        }

        public RPOSContext(DbContextOptions<RPOSContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<MenuForDay> MenuForDay { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
