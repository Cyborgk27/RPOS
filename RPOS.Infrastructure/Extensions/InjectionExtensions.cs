using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RPOS.Infrastructure.Persistences.Contexts;
using RPOS.Infrastructure.Persistences.Interfaces;
using RPOS.Infrastructure.Persistences.Repositories;

namespace RPOS.Infrastructure.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionInfrastructure(this IServiceCollection services
            , IConfiguration configuration)
        {
            var assembly = typeof(RPOSContext).Assembly.FullName;

            services.AddDbContext<RPOSContext>(
                options => options.UseSqlite(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(assembly)),
                ServiceLifetime.Transient);

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return services;
        }
    }
}
