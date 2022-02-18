using PointStore.Domain.Entity;

namespace PointStore.Domain.Interface.IService
{
    public interface IUsuarioService
    {
        /// <summary>
        /// Obter o usuário pelo login
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna os dados do usuário</returns>
        Task<Usuario> ObterUsuarioAsync(int id);
    }
}
