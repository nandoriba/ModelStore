using Microsoft.AspNetCore.Identity;
using ModelStore.Identidade.API.Data;
using ModelStore.Identidade.API.Extensions;

namespace ModelStore.Identidade.API.Configuration
{
    public static class IdentityConfig
    {
        public static IServiceCollection AddIdentityConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextConfiguration(configuration);

            services.AddDefaultIdentity<IdentityUser>()
                .AddErrorDescriber<IdentityTraducaoMensagens>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
            return services;
        }

        public static IApplicationBuilder UseIdentityConfiguration(this IApplicationBuilder app)
        {
            app.UseAuthentication();
            app.UseAuthorization();
            return app;
        }
    }
}
