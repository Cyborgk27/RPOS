﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RPOS.Domain.Entities;
using System.Reflection;

namespace RPOS.Infrastructure.Persistences.Contexts
{
    public partial class RPOSContext : IdentityDbContext<IdentityUser>
    {
        public RPOSContext()
        { 
        
        }

        public RPOSContext(DbContextOptions<RPOSContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Restaurant> Restaurants { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Address> Addresses { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
