using PointStore.Domain.Entity;

namespace PointStore.Domain.Interface.IService
{
    public interface IEmpresaService
    {
        /// <summary>
        /// Obter dados da empresa
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna dados da empresa</returns>
        Task<Empresa> ObterEmpresaAsync(int id);
    }
}
