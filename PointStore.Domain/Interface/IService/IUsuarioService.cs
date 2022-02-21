using PointStore.Domain.Entity;

namespace PointStore.Domain.Interface.IService
{
    public interface IUsuarioService
    {
        /// <summary>
        /// Verifica se o usuário atravez do seu id Cognito já possui cadastro no banco de dados.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna os dados do usuário</returns>
        Task<Usuario> ValidarUsuarioAsync(Guid id);
    }
}
