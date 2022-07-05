using Api.Data;
using Api.Helpers;
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
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);

            return services;
        }
    }
}
