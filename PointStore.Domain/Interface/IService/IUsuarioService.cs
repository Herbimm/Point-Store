using PointStore.Domain.Entity;

namespace PointStore.Domain.Interface.IService
{
    public interface IUsuarioService
    {
        /// <summary>
        /// Verifica se o usuário já existe no banco de dados, caso não, o cadastro será realizado.
        /// </summary>
        /// <param name="userName"></param>       
        /// <returns>Retorna os dados do usuário</returns>
        Task<Usuario> ValidarUsuarioAsync(string userName, string guid, string grupoUsuarioCognito);

        /// <summary>
        /// Cadastra usuário do Cognito no banco de dados
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="guid"></param>
        /// <param name="grupoUsuarioCognito"></param>
        /// <returns></returns>
        Task CadastrarUsuarioAsync(string userName, string guid, string grupoUsuarioCognito);
    }
}
