using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PointStore.CrossCutting.Utis;
using PointStore.Repository.Context;

namespace PointStore.CrossCutting.DependencyInjection
{
    public static class DependencyInjectionRepository
    {
        public static void AddDependencyInjectionRepository(IServiceCollection services,
            ConfigurationRepository configurationRepository )
        {

            services.AddSingleton(configurationRepository);

            // Adicionar o DbContext.

            services.AddDbContext<MyContext>(options => options.UseSqlServer(configurationRepository.ConnectionString));

        }
    }
}
