using Microsoft.Extensions.DependencyInjection;
using PointStore.CrossCutting.Utis;

namespace PointStore.CrossCutting.DependencyInjection
{
    public static class DependencyInjectionRepository
    {
        public static void AddDependencyInjectionRepository(IServiceCollection services,
            ConfigurationRepository configurationRepository )
        {

            services.AddSingleton(configurationRepository);
            
            // Adicionar o DbContext.

        }
    }
}
