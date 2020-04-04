using AAAA.Aplication.Interfaces;
using AAAA.Aplication.Services;
using AAAA.Domain.Interfaces;
using AAAA.Domain.Services;
using AAAA.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace AAAA.infra.CrossCutting.IOC
{
    public static class NativeInjector
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAuthenticationAppService, AuthenticationAppService>();
        }
    }
}
