using Microsoft.Extensions.DependencyInjection;
using PointStore.Domain.Interface.IService;
using PointStore.Service.Service;

namespace PointStore.CrossCutting.DependencyInjection
{
    public static class DependencyInjectionServices
    {
        public static void AddDependecyInjectionServices(IServiceCollection services)
        {
            services.AddScoped<IEmpresaService, EmpresaService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
        }
    }
}
