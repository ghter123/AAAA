using System;
using AAAA.infra.CrossCutting.IOC;
using Microsoft.Extensions.DependencyInjection;

namespace AAAA.Services.Api.Configurations
{
    public static class DependencyInjectionSetup
    {
        public static void AddDependencyInjectionSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            NativeInjector.RegisterServices(services);
        }
    }
}