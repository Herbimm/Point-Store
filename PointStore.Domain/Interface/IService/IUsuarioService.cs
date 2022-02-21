using PointStore.Domain.Entity;

namespace PointStore.Domain.Interface.IService
{
    public interface IUsuarioService
    {
        /// <summary>
        /// Verifica se o usuário já existe no banco de dados
        /// </summary>        
        /// <returns>Retorna os dados do usuário</returns>
        Task<Usuario> ValidarUsuarioAsync(Guid id);
    }
}
