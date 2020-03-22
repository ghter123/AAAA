using AAAA.Aplication.Interfaces;
using AAAA.Aplication.Services;
using AAAA.Domain.Interfaces;
using AAAA.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace AAAA.infra.CrossCutting.IOC
{
    public static class NativeInjector
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IUserAppService, UserAppService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAuthService, AuthService>();
        }
    }
}
