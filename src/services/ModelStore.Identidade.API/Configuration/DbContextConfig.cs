using Microsoft.EntityFrameworkCore;
using ModelStore.Identidade.API.Data;

namespace ModelStore.Identidade.API.Configuration
{
    public static class DbContextConfig
    {
        public static IServiceCollection AddDbContextConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            return services;
        }
    }
}
