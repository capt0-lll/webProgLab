using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataLayer.Extensions
{
    public static class DataLayerExtansions
    {
        public static IServiceCollection AddContext(this IServiceCollection services,
            string connectionString,
            string migrationsAssembly = "")
        {
            services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connectionString));

            return services;
        }

    }
}