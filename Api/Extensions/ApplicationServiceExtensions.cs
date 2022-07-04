using Api.Data;
using Api.Interfaces;
using Api.Services;

namespace Api.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApllicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DataContext>(options =>
                 options.UseSqlServer(config.GetConnectionString("DefaultConnection")));


            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}
