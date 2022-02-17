using Microsoft.Extensions.DependencyInjection;
using PointStore.CrossCutting.Utis;
using PointStore.Domain.Interface.IRepository;
using PointStore.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointStore.CrossCutting.DependencyInjection
{
    public static class DependencyInjectionRepository
    {
        public static void AddDependencyInjectionRepository(IServiceCollection services,
            ConfigurationRepository configurationRepository )
        {
            services.AddScoped<IPointsRepository, PointsRepository>();
            services.AddScoped<ICadastroRepository, CadastroRepository>();

            services.AddSingleton(configurationRepository);
            
            // Adicionar o DbContext.

        }
    }
}
