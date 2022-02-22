using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PointStore.CrossCutting.Utis;
using PointStore.Domain.Interface.Repository;
using PointStore.Repository.Context;
using PointStore.Repository.Implementacao;

namespace PointStore.CrossCutting.DependencyInjection
{
    public static class DependencyInjectionRepository
    {
        public static void AddDependencyInjectionRepository(IServiceCollection services,
            ConfigurationRepository configurationRepository)
        {
            services.AddScoped<IUsuariosRepository, UsuarioRepository>();

            services.AddSingleton(configurationRepository);
            services.AddDbContext<MyContext>(options => options.UseSqlServer(configurationRepository.ConnectionString));
        }
    }
}
